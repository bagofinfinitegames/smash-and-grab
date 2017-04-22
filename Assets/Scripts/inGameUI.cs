using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inGameUI : MonoBehaviour {

    public GUIText playerHealth;

    void SetHealth(int health) {
        playerHealth.text = health.ToString();
    }
}
