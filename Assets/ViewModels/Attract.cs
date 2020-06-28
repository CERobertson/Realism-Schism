using static Controls;

public class Attract : AttachControlToGameMonoBehavior<AttractActions, AttractControl> {
    protected override void AttacheEventsToControls(Controls controls, AttractControl attract)
        => attract.InteractStarted += (s, cc) => {
            attract.gameObject.SetActive(false);
            Game.AccessWithRetry((c) => {
                c.SkipTutorial.gameObject.SetActive(true);
                c.SkipTutorial.enabled = true;
            });
        };
}
