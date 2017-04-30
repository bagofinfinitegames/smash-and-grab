using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    public Transform target;
    public Transform[] patrolPoints;
    public int destinationPoint = 0;
    public UnityEngine.AI.NavMeshAgent agent;
    public float viewDistance = 5.0f;
    public int dropRate = 5; // drop rate is 1 in dropRate
    public GameObject drop;
    //public enum State { wander, attack };
    //public State state = State.wander;

    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GoToCurrentPoint();
        agent.autoBraking = false;
    }

    void Update() {
        float distToTarget = Vector3.Distance(target.position, transform.position);

        if (distToTarget < viewDistance) {
            agent.destination = target.position;
        } else if (agent.remainingDistance < 0.5f) {
            GoToNextPoint();
            //agent.destination = transform.position;
            //agent.Stop();
        }

        //if (agent.remainingDistance < 0.5f) {
        //    GoToNextPoint();
        //}
    }

    void GoToCurrentPoint() {
        agent.destination = patrolPoints[destinationPoint].position;
    }

    void GoToNextPoint() {
        destinationPoint = (destinationPoint + 1) % patrolPoints.Length;
        agent.destination = patrolPoints[destinationPoint].position;
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
