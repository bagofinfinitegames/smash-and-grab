using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
    public GameObject PickupParticles;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Got Hit!");
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Player hit!");
            Destroy(gameObject);
            Instantiate(PickupParticles, transform.position, Quaternion.identity);
        }
    }
}
