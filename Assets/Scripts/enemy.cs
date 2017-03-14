using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    public Transform target;
    public NavMeshAgent agent;
    public float viewDistance = 5.0f;

    void Start() {
        agent = GetComponent<NavMeshAgent>();
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
}
