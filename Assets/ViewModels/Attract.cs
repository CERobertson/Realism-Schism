using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class Attract : AttachToGameMonoBehavior {
    protected override void CreateControl(Controls controls) {
        var attract = new AttractControl();
        attract.InteractStarted += (s, c) => gameObject.SetActive(false);
        controls.Attract.SetCallbacks(attract);
        controls.Attract.Enable();
    }
    protected override void DisableControl(Controls controls) => controls.Attract.Disable();
}
