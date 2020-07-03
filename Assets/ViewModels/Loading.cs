using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Controls;

public class Loading : AttachControlToGameMonoBehavior<LoadingActions, LoadingControl> {
    protected override void AttacheEventsToControls(Controls controls, LoadingControl c) {
        //ControlMonoBehavior.ContinueStarted
    }
}
