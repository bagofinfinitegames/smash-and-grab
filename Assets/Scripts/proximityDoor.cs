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
            doorAnim.SetTrigger("Open");
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")) {
            doorAnim.SetTrigger("Close");
        }
    }
}
