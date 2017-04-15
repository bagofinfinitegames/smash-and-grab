using UnityEngine;
using System.Collections;

public class puzzle : MonoBehaviour {
    public bool activated = false;
    public GameObject[] triggers;
    public Light myLight;
    public AudioClip successSound;
    public AudioSource audioSource;

	void Start () {
	    if(myLight == null) {
            myLight = this.transform.Find("Puzzle Light").GetComponent<Light>();
        }
        if(audioSource == null) {
            audioSource = transform.GetComponent<AudioSource>();
            audioSource.clip = successSound;
        }
	}
	
	void Update () {
        if (checkTriggers() && !activated) {
            activated = true;
            audioSource.Play();
            StartCoroutine(TurnOnLightInSeconds(0.75f));
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

    IEnumerator TurnOnLightInSeconds(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        myLight.enabled = true;
    }
}
