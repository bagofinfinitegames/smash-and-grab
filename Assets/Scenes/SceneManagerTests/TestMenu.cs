using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestMenu : MonoBehaviour {
    public string curScene = "";

    void Start() {
        LoadScene("BG_Test", curScene);
    }

    public void LoadScene(string sceneToLoad) {
        LoadScene(sceneToLoad, curScene);
    }

    private void LoadScene(string newScene, string oldScene) {
        if(curScene != "") {
            SceneManager.UnloadSceneAsync(oldScene);
        }
        SceneManager.LoadScene(newScene, LoadSceneMode.Additive);
        curScene = newScene;
    }
}
