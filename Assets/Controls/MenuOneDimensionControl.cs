﻿using System;
using UnityEngine.InputSystem;
using static Controls;
public class MenuOneDimensionControl : IMenuOneDimensionActions {
    public event EventHandler<InputAction.CallbackContext> ForwardStarted;
    public event EventHandler<InputAction.CallbackContext> BackwardStarted;
    public event EventHandler<InputAction.CallbackContext> ConfirmStarted;
    public event EventHandler<InputAction.CallbackContext> CancelStarted;
    public void OnForward(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Started)
            ForwardStarted?.Invoke(this, context);
    }
    public void OnBackward(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Started)
            BackwardStarted?.Invoke(this, context);
    }
    public void OnConfirm(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Started)
            ConfirmStarted?.Invoke(this, context);
    }
    public void OnCancel(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Started)
            CancelStarted?.Invoke(this, context);
    }
}