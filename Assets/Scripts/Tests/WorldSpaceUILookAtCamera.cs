using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpaceUILookAtCamera : MonoBehaviour {
    public Transform mainCamera;

	void Start () {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera")
                        .GetComponent<Transform>();
	}
	
	void Update () {
        transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.position);
	}
}
