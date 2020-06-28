using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttractSceneManager : SceneManagerControl {
    public SceneAsset MenuScene;
    public SceneAsset JapaneseMaple;
    public void OnEnable() => Game.AccessWithRetry(g => {
        g.Attract.gameObject.SetActive(true);
        g.Attract.enabled = true;
        g.SkipTutorial.OnChoice += (s, choice) => {
            switch ((SkipTutorial.Choice)choice) {
                case (SkipTutorial.Choice.yes):
                    SceneManager.LoadScene(JapaneseMaple.name);
                    break;
                case (SkipTutorial.Choice.no):
                    SceneManager.LoadScene(MenuScene.name);
                    break;
                default:
                    Debug.LogWarning($"Unexepected 3rd option '{choice}'");
                    break;
            }
        };
    });
}
