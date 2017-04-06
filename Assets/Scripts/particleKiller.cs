using UnityEngine;
using System.Collections;

public class particleKiller : MonoBehaviour {
    public ParticleSystem ps;

	void Start () {
        ps = GetComponent<ParticleSystem>();
	}
	
	void Update () {
        if (ps) {
            if (!ps.IsAlive()) {
                Destroy(gameObject);
            }
        }
	}
}
