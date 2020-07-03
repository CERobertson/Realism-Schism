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
            SceneManager.sceneLoaded += (s, scene) => {
                SceneManagerControl = GameObject.Find("SceneManager")?.GetComponent<SceneManagerControl>();
                if (SceneManagerControl != null)
                    SceneManagerControl.enabled = true;
            };
            SceneManager.sceneUnloaded += (s) =>
                SceneManagerControl = null;
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Debug.LogWarning("Only one instance of MonoBehavior Game should be running.");
    }

    public event EventHandler<SceneManagerControl> SceneManagerControlChanged;
    public SceneManagerControl sceneManagerControl;
    public SceneManagerControl SceneManagerControl {
        get => sceneManagerControl;
        set {
            sceneManagerControl = value;
            SceneManagerControlChanged?.Invoke(this, value);
        }
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

public abstract class AttachControlToGameMonoBehavior<Action, Control> : MonoBehaviour 
    where Action : struct
    where Control : MonoBehaviorControl<Action, Control> {

    public GameObject ControlGameObject;
    public Control ControlMonoBehavior;

    public void Awake() {
        CreateControl(AttacheEventsToControls);
        AttachToGame(ControlMonoBehavior);
        ControlMonoBehavior.Game = this;
    }
    protected abstract void AttacheEventsToControls(Controls controls, Control c);
    protected void AttachToGame<T>(T value) =>
        SharedGame.AccessWithRetry(g => typeof(SharedGame).GetProperty(GetType().Name).SetValue(g, value));
    protected void DetachFromGame() =>
        SharedGame.AccessWithRetry(g => typeof(SharedGame).GetProperty(GetType().Name).SetValue(g, null));
    protected void CreateControl(Action<Controls, Control> attachEventHandlers) =>
        SharedControls.AccessWithRetry(c => { 
            ControlMonoBehavior = ControlGameObject.AddComponent<Control>();
            attachEventHandlers(c, ControlMonoBehavior);
            var action = typeof(Controls).GetProperty(ControlMonoBehavior.Name).GetValue(c);
            action.GetType().GetMethod(SharedControls.SetCallbacksMethodName).Invoke(action, new[] { ControlMonoBehavior });
            ControlMonoBehavior.enabled = false;
        });
    public void EnableControl() =>
        SharedControls.AccessWithRetry(c => {
            ControlGameObject.SetActive(true);
            var action = typeof(Controls).GetProperty(ControlMonoBehavior.Name).GetValue(c);
            action.GetType().GetMethod(SharedControls.EnableMethodName).Invoke(action, null);
        });
    public void DisableControl() =>
        SharedControls.AccessWithRetry(c => {
            var action = typeof(Controls).GetProperty(ControlMonoBehavior.Name).GetValue(c);
            action.GetType().GetMethod(SharedControls.DisableMethodName).Invoke(action, null);
            ControlGameObject.SetActive(false);
        });
}

