using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {
    public int highScore = 0;
    public int currentScore = 0;

	void Start () {
        highScore = loadHighScore();
    }

    // Returns the saved highscore or 0 if there is no existing save.
    int loadHighScore() {
        if (Exists("HighScore")) {
            return LoadInt("HighScore");
        } else {
            return 0;
        }
    }

    // Saves the passed score only if it is greater than the last saved score.
    public void saveHighScore(int highScore) {
        int curHighScore = LoadInt("HighScore");
        if(highScore > curHighScore) {
            SaveInt("HighScore", highScore);
        }
    }

    bool Exists(string key) {
        return PlayerPrefs.HasKey(key);
    }

    int LoadInt(string key) {
        return PlayerPrefs.GetInt(key);
    }

    float LoadFloat(string key) {
        return PlayerPrefs.GetFloat(key);
    }

    void SaveInt(string key, int value) {
        PlayerPrefs.SetInt(key, value);
    }

    void SaveFloat(string key, float value) {
        PlayerPrefs.SetFloat(key, value);
    }

    void ClearSaves() {
        PlayerPrefs.DeleteAll();
    }

    void RemoveKey(string keyToRemove) {
        PlayerPrefs.DeleteKey(keyToRemove);
    }
}
