﻿using System;
using System.Collections;
using System.Threading;
using UnityEngine;

/// <summary>
/// Static Singleton is intended to control access to shared
/// classes. 
/// </summary>
public static class SharedControls {
    static SharedControls() => controls = new Controls();
    static Controls controls { get; }
    static SemaphoreSlim _control_lock = new SemaphoreSlim(1);
    public static bool Access(Action<Controls> updateControls) {
        if (_control_lock.CurrentCount != 0) {
            _control_lock.Wait();
            updateControls(controls);
            _control_lock.Release();
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
