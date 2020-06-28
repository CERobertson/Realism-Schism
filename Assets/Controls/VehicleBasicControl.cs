using UnityEngine.InputSystem;
using static Controls;

public class VehicleBasicControl : MonoBehaviorControl<VehicleBasicActions, VehicleBasicControl>, IVehicleBasicActions {
    public void OnToggleExternalConsole(InputAction.CallbackContext context) {
    }

    public void OnToggleInternalConsole(InputAction.CallbackContext context) {
    }

    public void OnToggleLookMode(InputAction.CallbackContext context) {
    }
}
