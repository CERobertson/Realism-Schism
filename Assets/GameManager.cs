using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Scenes InitialScene;
    public GameObject InitialCamera;
    public GameObject LoadingScreen;
    public ProgressBar ProgressBar;

    void Awake() {
        instance = this;
        AddScene(InitialScene);
    }
    public void Load(Scenes scene) {
        LoadingScreen.gameObject.SetActive(true);
        UnloadScene();
        AddScene(scene);
        StartCoroutine(GetSceneLoadProgress());
    }
    IList<AsyncOperation> ScenesLoading = new List<AsyncOperation>();
    IList<Scenes> LoadedScenes = new List<Scenes>();
    public void AddScene(Scenes scene) {
        ScenesLoading.Add(SceneManager.LoadSceneAsync((int)scene, LoadSceneMode.Additive));
        LoadedScenes.Add(scene);
    }

    public void UnloadScene(Scenes scene) {
        ScenesLoading.Add(SceneManager.UnloadSceneAsync((int)scene));
        LoadedScenes.Remove(scene);
    }

    public void UnloadScene() {
        foreach(var scene in LoadedScenes) {
            UnloadScene(scene);
        }
    }
    public IEnumerator GetSceneLoadProgress() {
        var finished = false;
        while(!finished) {
            finished = ScenesLoading.Aggregate(false, (accum, x) => accum &= x.isDone);
            yield return new WaitForEndOfFrame();
        }
    }
}
