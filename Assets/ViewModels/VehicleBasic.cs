using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Controls;

public class VehicleBasic : AttachControlToGameMonoBehavior<VehicleBasicActions, VehicleBasicControl> {
    protected override void AttacheEventsToControls(Controls controls, VehicleBasicControl c) {
    }
}
