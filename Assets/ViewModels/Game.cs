using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Controls;

public class Game : AttachControlToGameMonoBehavior<GameActions, GameControl> {
    protected override void AttacheEventsToControls(Controls controls, GameControl c) {
    }
}
