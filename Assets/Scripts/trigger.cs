using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
    public bool isActive = false;
    public float delay = 5.0f;
    public float offTime;
    public float distance = 1.0f;
    public GameObject player;
    public Light myLight;

    void Start() {
        if (player == null) {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if(myLight == null) {
            myLight = this.transform.Find("Trigger Light").GetComponent<Light>();
        }
    }

    void Update () {
        if(!isActive && Vector3.Distance(transform.position, player.transform.position) < distance) {
            isActive = true;
            myLight.enabled = true;
            offTime = delay + Time.time;
        }

        if (isActive && Time.time >= offTime) {
            isActive = false;
            myLight.enabled = false;
        }
    }

    public bool getActive() {
        return isActive;
    }

    public void setActive(bool active) {
        if (active) {
            isActive = true;
            myLight.enabled = true;
        } else {
            isActive = false;
            myLight.enabled = false;
        }
    }
}
