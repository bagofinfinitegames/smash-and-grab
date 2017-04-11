using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
    public Transform cameraTarget;
    public float cameraSpeed = 10.0f;
    public float offsetY = 10.0f;
    public float offsetZ = 10.0f;

	void Start () {
	    if(cameraTarget == null) {
            cameraTarget = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }
	}

    private void LateUpdate() {
    }

    private void FixedUpdate() {
        transform.LookAt(cameraTarget);
        //transform.position = new Vector3(
        //    transform.position.x,
        //    cameraTarget.position.y + offsetY,
        //    cameraTarget.position.z + offsetZ);
        Vector3 newPosition = new Vector3(cameraTarget.position.x, cameraTarget.position.y + offsetY, cameraTarget.position.z + offsetZ);
        transform.position = Vector3.Lerp(transform.position, newPosition, cameraSpeed * Time.deltaTime);
        
    }
}
