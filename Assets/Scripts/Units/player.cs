using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    public UnityEngine.AI.NavMeshAgent agent;
    public Transform weaponSocket;
    public GameObject weapon;

    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject myWeapon = Instantiate(weapon, weaponSocket.position, weaponSocket.rotation);
        myWeapon.transform.parent = player.transform;
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                //if (hit.transform.gameObject.CompareTag("Ground")) {
                //    Debug.Log("Hit the ground");
                //}
                agent.destination = hit.point;
            }
        }
    }

    void Die() {
        Debug.Log("Player is dead");
    }
}
