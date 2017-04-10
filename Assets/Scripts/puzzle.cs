using UnityEngine;
using System.Collections;

public class puzzle : MonoBehaviour {
    public GameObject[] triggers;
    public Light myLight;

	// Use this for initialization
	void Start () {
	    if(myLight == null) {
            myLight = this.transform.Find("Puzzle Light").GetComponent<Light>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (checkTriggers()) {
            myLight.enabled = true;
        }
	}

    bool checkTriggers() {
        int total = 0;

        foreach (GameObject trigger in triggers) {
            trigger tmpTrigger = trigger.GetComponent<trigger>();
            if (tmpTrigger.getActive()) {
                total += 1;
            }
        }

        if(total == triggers.Length) {
            return true;
        } else {
            return false;
        }
    }
}
