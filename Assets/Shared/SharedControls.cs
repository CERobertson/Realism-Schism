using System;
using System.Collections;
using System.Threading;
using UnityEngine;

/// <summary>
/// Static Singleton is intended to control access to shared
/// classes. 
/// </summary>
public static class SharedControls {
    public static readonly string DisableMethodName = "Disable";
    public static readonly string EnableMethodName = "Enable";
    public static readonly string SetCallbacksMethodName = "SetCallbacks";

    static SharedControls() => controls = new Controls();
    static Controls controls { get; }
    static SemaphoreSlim _control_lock = new SemaphoreSlim(1);
    public static bool Access(Action<Controls> updateControls) {
        if (_control_lock.CurrentCount != 0) {
            _control_lock.Wait();
            try {
                updateControls(controls);
            }
            finally {
                _control_lock.Release();
            }
            return true;
        }
        else
            Debug.LogWarning($"'{updateControls.GetType()}' failed to obtain control lock. Consider retrying");
        return false;
    }
    public static void AccessWithRetry(Action<Controls> updateControl, float delay_between_checks = 0.01f) 
        => Game.MonoBehavior.StartCoroutine(accessWithRetry(updateControl, delay_between_checks));
    static IEnumerator accessWithRetry(Action<Controls> updateControl, float delay_between_checks) {
        while (!Access(updateControl))
            yield return new WaitForSeconds(delay_between_checks);
    }
}

public interface IActions {
    void Enable();
    void Disable();
    void SetCallbacks<T>(T instance);
}