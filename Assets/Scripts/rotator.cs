using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {
    public float speed = 50.0f;

	void Update () {
        float speedTime = speed * Time.deltaTime;
        transform.Rotate(speedTime, speedTime, speedTime);
	}
}
