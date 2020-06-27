using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipTutorial : AttachToGameMonoBehavior {
    protected override void CreateControl(Controls controls) {
        var menu = new MenuOneDimensionControl();
        menu.ForwardStarted += (s, c) => index++;
        menu.BackwardStarted += (s, c) => index--;
        menu.CancelStarted += (s, c) => gameObject.SetActive(false);
        menu.ConfirmStarted += (s, c) => OnChoice?.Invoke(this, (Choice)index);
        controls.MenuOneDimension.SetCallbacks(menu);
        controls.MenuOneDimension.Enable();
    }
    protected override void DisableControl(Controls controls) => controls.MenuOneDimension.Disable();
    public enum Choice{
        yes,
        no
    }
    public event EventHandler<Choice> OnChoice;
    public Image[] Options;

    int _index;
    int index {
        get => _index;
        set => _index = value % Options.Length;
    }
}
