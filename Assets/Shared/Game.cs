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
            try {
                updateGame(Instance);
            }
            finally {
                _lock.Release();
            }
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

public abstract class AttachToGameMonoBehavior<Action, Control> : MonoBehaviour 
    where Action : struct
    where Control : class, new() {
    public void Awake() => AttachToGame(this);
    public void OnEnable() => CreateControl(AttacheEventsToControls);
    public void OnDisable() => DisableControl();
    public void OnDestroy() => DetachFromGame();

    protected abstract void AttacheEventsToControls(Controls controls, Control c);
    protected void AttachToGame<T>(T value) =>
        Game.AccessWithRetry(g => typeof(Game).GetProperty(GetType().Name, GetType()).SetValue(g, value));
    protected void DetachFromGame() =>
        Game.AccessWithRetry(g => typeof(Game).GetProperty(GetType().Name, GetType()).SetValue(g, null));

    protected void CreateControl(Action<Controls, Control> attachEventHandlers) =>
        SharedControls.AccessWithRetry(c => { 
            var control = new Control();
            attachEventHandlers(c, control);
            var action = typeof(Controls).GetProperty(GetType().Name, typeof(Action)).GetValue(c);
            action.GetType().GetMethod(SharedControls.SetCallbacksMethodName).Invoke(action, new[] { control });
            action.GetType().GetMethod(SharedControls.EnableMethodName).Invoke(action, null);
        });

    protected void DisableControl() =>
        SharedControls.AccessWithRetry(c => {
            var action = typeof(Controls).GetProperty(GetType().Name, typeof(Action)).GetValue(c);
            action.GetType().GetMethod(SharedControls.DisableMethodName).Invoke(action, null);
        });
}

