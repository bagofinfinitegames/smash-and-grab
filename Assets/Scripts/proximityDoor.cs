using UnityEngine;
using System.Collections;

public class proximityDoor : MonoBehaviour {
    public GameObject door;
    public Animator doorAnim;

    void Start() {
        doorAnim = door.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            Debug.Log("Open for player");
            doorAnim.SetTrigger("Open");
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")) {
            Debug.Log("Close for player");
            doorAnim.SetTrigger("Close");
        }
    }
}
