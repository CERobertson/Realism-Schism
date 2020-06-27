using System;
using UnityEngine.InputSystem;
using static Controls;

public class AttractControl : IAttractActions {

    public event EventHandler<InputAction.CallbackContext> InteractStarted;
    public void OnInteract(InputAction.CallbackContext context) {
        if (context.phase == InputActionPhase.Started)
            InteractStarted?.Invoke(this, context);
    }
}
