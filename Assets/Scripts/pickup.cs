using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
    //public GameObject PickupParticles;
    public enum PickupTypes { Health = 0, Ammo = 1, Weapon = 1 };
    public PickupTypes myType = PickupTypes.Health;
    public int id;
    public PickupSettings[] myPickupSettings;
    public Transform myGeometry;

    private void Start() {
        if(myGeometry == null) {
            myGeometry = transform.GetChild(0);
        }
        id = (int)myType;
        MeshFilter myFilter = myGeometry.GetComponent<MeshFilter>();
        myFilter.sharedMesh = myPickupSettings[id].mesh;
        Renderer myRenderer = myGeometry.GetComponent<Renderer>();
        myRenderer.material.mainTexture = myPickupSettings[id].texture;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
            Instantiate(myPickupSettings[id].particles, transform.position, Quaternion.identity);
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