using static Controls;

public class Attract : AttachControlToGameMonoBehavior<AttractActions, AttractControl> {
    protected override void AttacheEventsToControls(Controls controls, AttractControl attract)
        => attract.InteractStarted += (s, cc) => {
            attract.gameObject.SetActive(false);
            SharedGame.AccessWithRetry((c) => {
                c.QuickStart.gameObject.SetActive(true);
                c.QuickStart.enabled = true;
            });
        };
}
