using System;
using UnityEngine.UI;
using static Controls;

public class SkipTutorial : AttachToGameMonoBehavior<MenuOneDimensionActions, MenuOneDimensionControl> {
    protected override void AttacheEventsToControls(Controls controls, MenuOneDimensionControl menu) {
        menu.ForwardStarted += (s, c) => index++;
        menu.BackwardStarted += (s, c) => index--;
        menu.CancelStarted += (s, c) => gameObject.SetActive(false);
        menu.ConfirmStarted += (s, c) => OnChoice?.Invoke(this, (Choice)index);
    }
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
