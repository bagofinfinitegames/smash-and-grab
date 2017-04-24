using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthUI : MonoBehaviour {

    public Text unitHealth;

    private void Start() {
        if(unitHealth == null) {
            unitHealth = GetComponent<Text>();
        }
    }

    public void SetHealth(float health) {
        if (unitHealth) {
            unitHealth.text = health.ToString();
        }
    }
}
