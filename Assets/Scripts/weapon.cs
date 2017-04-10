using UnityEngine;
using System.Collections;

public class weapon : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy" || other.tag == "Player") {
            Debug.Log("Do damage");
            other.GetComponent<life>().takeDamage(2);
        }
    }
}
