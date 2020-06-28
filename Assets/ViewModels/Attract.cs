using static Controls;

public class Attract : AttachToGameMonoBehavior<AttractActions, AttractControl> {
    protected override void AttacheEventsToControls(Controls controls, AttractControl attract) 
        => attract.InteractStarted += (s, c) => gameObject.SetActive(false);
}
