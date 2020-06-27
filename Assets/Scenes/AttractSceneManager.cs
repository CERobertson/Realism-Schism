using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractSceneManager : MonoBehaviour {
    public void Awake() => Game.Access(g => g.AttractChanged += (s, attract) => attract?.gameObject.SetActive(true));
}
