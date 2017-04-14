using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
    public GameObject PickupParticles;
    public enum PickupTypes { Health = 1, Ammo = 2, Weapon = 3 };
    public PickupTypes myType = PickupTypes.Health;
    public PickupSettings[] myPickupSettings;
    public Transform myGeometry;

    private void Start() {
        if(myGeometry == null) {
            myGeometry = transform.GetChild(0);
        }
        Debug.Log(myType);
        int id = (int)myType;
        MeshFilter myFilter = myGeometry.GetComponent<MeshFilter>();
        myFilter.sharedMesh = myPickupSettings[id].mesh;
        //texture
        //material
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Got Hit!");
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Player hit!");
            Destroy(gameObject);
            Instantiate(PickupParticles, transform.position, Quaternion.identity);
        }
    }
}

[System.Serializable]
public class PickupSettings {
    public string type;
    public int value;
    public Mesh mesh;
    public Material material;
    public Texture2D texture;
    public GameObject particles;
}