using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using static Controls;

public class LoadingControl : MonoBehaviour, ILoadingActions {
    public SceneAsset Scene;

    public event EventHandler<InputAction.CallbackContext> ContinueStarted;
    public event EventHandler<InputAction.CallbackContext> NextHintStarted;
    public event EventHandler<InputAction.CallbackContext> PreviousHintStarted;

    public void OnContinue(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Started)
            ContinueStarted?.Invoke(this, context);
    }

    public void OnNextHint(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Started)
            NextHintStarted?.Invoke(this, context);
    }

    public void OnPreviousHint(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Started)
            PreviousHintStarted?.Invoke(this, context);
    }
}
