using System;
using UnityEngine;

public class MonoBehaviorControl<Action, Control> : MonoBehaviour
    where Action : struct
    where Control : MonoBehaviorControl<Action, Control> {
    const string suffix = "Control";

    public AttachControlToGameMonoBehavior<Action, Control> Game;

    public void OnEnable() => Game.EnableControl();
    public void OnDisable() => Game?.DisableControl();

    string _name;
    public string Name { 
        get {
            if (string.IsNullOrEmpty(_name)) {
                var name = GetType().Name;
                _name = name.Remove(name.Length - suffix.Length, suffix.Length);
            }
            return _name;
        }
    }
}
