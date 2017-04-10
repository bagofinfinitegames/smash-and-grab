using UnityEngine;
using System.Collections;

public class life : MonoBehaviour {
    public float maxLife = 10;
    public float curLife = 10;

    public void Update() {
        if(curLife > maxLife) {
            curLife = maxLife;
        }
    }

    public void takeDamage(int damage) {
        Debug.Log("Taking damage");
        curLife -= damage;
    }

    public void healDamage(int life) {
        Debug.Log("Gaining Life");
        curLife += life;
    }
}
