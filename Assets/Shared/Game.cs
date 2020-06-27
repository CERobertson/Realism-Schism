using System;
using System.Collections;
using System.Threading;
using UnityEngine;

public class Game : MonoBehaviour
{
    public event EventHandler<Attract> AttractChanged;
    public Attract attract;
    public Attract Attract {
        get => attract;
        set {
            attract = value;
            AttractChanged?.Invoke(this, value);
        }
    }
    public event EventHandler<SkipTutorial> SkipTutorialChanged;
    public SkipTutorial skipTutorial;
    public SkipTutorial SkipTutorial {
        get => skipTutorial;
        set {
            skipTutorial = value;
            SkipTutorialChanged?.Invoke(this, value);
        }
    }

    static Game Instance;
    public static MonoBehaviour MonoBehavior { get => Instance; }
    public void Awake() {
        if (Instance == null)
            Instance = this;
        else
            Debug.LogWarning("Only one instance of MonoBehavior Game should be running.");
    }
    
    static SemaphoreSlim _lock = new SemaphoreSlim(1);
    public static bool Access(Action<Game> updateGame) {
        if (_lock.CurrentCount != 0) {
            _lock.Wait();
            updateGame(Instance);
            _lock.Release();
            return true;
        }
        else
            Debug.Log($"Failed to obtain access lock. Consider retrying");
        return false;
    }
    public static void AccessWithRetry(Action<Game> updateGame, float delay_between_checks = 0.01f) 
        => Instance.StartCoroutine(accessWithRetry(updateGame, delay_between_checks));
    static IEnumerator accessWithRetry(Action<Game> updateGame, float delay_between_checks) {
        while (!Access(updateGame))
            yield return new WaitForSeconds(delay_between_checks);
    }
}

public abstract class AttachToGameMonoBehavior : MonoBehaviour
{
    public void Awake() => AttachToGame(this);

    public void OnEnable() => SharedControls.AccessWithRetry(CreateControl);
    public void OnDisable() => SharedControls.AccessWithRetry(DisableControl);
    public void OnDestroy() => DettachFromGame();

    protected abstract void CreateControl(Controls controls);
    protected abstract void DisableControl(Controls controls);
    protected void AttachToGame<T>(T value) => 
        Game.AccessWithRetry(g => typeof(Game).GetProperty(GetType().Name, GetType()).SetValue(g, value));
    protected void DettachFromGame() =>
        Game.AccessWithRetry(g => typeof(Game).GetProperty(GetType().Name, GetType()).SetValue(g, null));
}

