using UnityEngine;
using System.Collections;

public class pickupLife : MonoBehaviour {
    public int lifeValue = 2;
    public GameObject particles;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Runned Over");
        if (other.CompareTag("Player")) {
            Debug.Log("Add Life");
            other.GetComponent<life>().healDamage(lifeValue);
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

}
