using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Got Hit!");
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Player hit!");
            Destroy(gameObject);
        }
    }
}
