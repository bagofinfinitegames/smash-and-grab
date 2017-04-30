using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    public Transform target;
    public UnityEngine.AI.NavMeshAgent agent;
    public float viewDistance = 5.0f;
    public int dropRate = 5; // drop rate is 1 in dropRate
    public GameObject drop;

    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update() {
        float distToTarget = Vector3.Distance(target.position, transform.position);

        if (distToTarget < viewDistance) {
            agent.destination = target.position;
        } else {
            agent.destination = transform.position;
            //agent.Stop();
        }
    }

    void Die() {
        Debug.Log("Enemy is Dead");

        int rand = Random.Range(0, dropRate);
        if(rand == 0) {
            Debug.Log("Chanced to drop");
            Instantiate(drop, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
