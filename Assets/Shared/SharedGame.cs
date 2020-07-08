using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharedGame : MonoBehaviour {
    static SharedGame Instance;
    public static MonoBehaviour MonoBehavior { get => Instance; }
    public void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Debug.LogWarning("Only one instance of MonoBehavior Game should be running.");
    }

    public event EventHandler<AttractControl> AttractChanged;
    public AttractControl attract;
    public AttractControl Attract {
        get => attract;
        set {
            attract = value;
            AttractChanged?.Invoke(this, value);
        }
    }
    public event EventHandler<MenuOneDimensionControl> QuickStartChanged;
    public MenuOneDimensionControl quickStart;
    public MenuOneDimensionControl QuickStart {
        get => quickStart;
        set {
            quickStart = value;
            QuickStartChanged?.Invoke(this, value);
        }
    }

    public event EventHandler<GameControl> GameChanged;
    public GameControl game;
    public GameControl Game {
        get => game;
        set {
            game = value;
            GameChanged?.Invoke(this, value);
        }
    }

    public event EventHandler<VehicleBasicControl> VehicleBasicChanged;
    public VehicleBasicControl vehicleBasic;
    public VehicleBasicControl VehicleBasic {
        get => vehicleBasic;
        set {
            vehicleBasic = value;
            VehicleBasicChanged?.Invoke(this, value);
        }
    }
    
    static SemaphoreSlim _lock = new SemaphoreSlim(1);
    public static bool Access(Action<SharedGame> updateGame) {
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
    public static void AccessWithRetry(Action<SharedGame> updateGame, float delay_between_checks = 0.01f) 
        => Instance.StartCoroutine(accessWithRetry(updateGame, delay_between_checks));
    static IEnumerator accessWithRetry(Action<SharedGame> updateGame, float delay_between_checks) {
        while (!Access(updateGame))
            yield return new WaitForSeconds(delay_between_checks);
    }
}

