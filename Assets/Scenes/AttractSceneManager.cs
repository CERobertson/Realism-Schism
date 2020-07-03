using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttractSceneManager : SceneManagerControl {
    public SceneAsset MenuScene;
    public SceneAsset JapaneseMaple;
    public void OnEnable() => SharedGame.AccessWithRetry(g => {
        g.Attract.gameObject.SetActive(true);
        g.Attract.enabled = true;
        g.QuickStart.OnChoice += (s, choice) => {
            switch ((QuickStart.Choice)choice) {
                case (QuickStart.Choice.yes):
                    SceneManager.LoadScene(JapaneseMaple.name);
                    break;
                case (QuickStart.Choice.no):
                    SceneManager.LoadScene(MenuScene.name);
                    break;
                default:
                    Debug.LogWarning($"Unexepected 3rd option '{choice}'");
                    break;
            }
        };
    });
}
