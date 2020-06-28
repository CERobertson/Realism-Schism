using System;
using UnityEngine.UI;
using static Controls;

public class SkipTutorial : AttachControlToGameMonoBehavior<MenuOneDimensionActions, MenuOneDimensionControl> {
    protected override void AttacheEventsToControls(Controls controls, MenuOneDimensionControl menu) {
        menu.ForwardStarted += (s, c) => index++;
        menu.BackwardStarted += (s, c) => index--;
        menu.CancelStarted += (s, cc) => {
            menu.gameObject.SetActive(false);
            Game.AccessWithRetry((c) => {
                c.Attract.gameObject.SetActive(true);
                c.Attract.enabled = true;
            });
        };
        menu.ConfirmStarted += (s, c) => menu.Choose(index);
    }
    public enum Choice{
        yes,
        no
    }
    public Image[] Options;

    int _index;
    int index {
        get => _index;
        set {
            Options[_index].enabled = false;
            _index = Math.Abs(value % Options.Length);
            Options[_index].enabled = true;
        }
    }
}
