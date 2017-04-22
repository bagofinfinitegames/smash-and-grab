using UnityEngine;
using System.Collections;

public class weapon : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy" || other.tag == "Player") {
            other.GetComponent<life>().takeDamage(2);
        }
    }
}
