﻿using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    public UnityEngine.AI.NavMeshAgent agent;

    void Start() {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
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
}
