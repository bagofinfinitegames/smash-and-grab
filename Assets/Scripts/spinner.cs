using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour {
    public float speed = 50.0f;
    public float offset = 0.333f;

	void Update () {
        transform.Rotate(0, speed * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 0.5f) + offset, transform.position.z);
    }
}
