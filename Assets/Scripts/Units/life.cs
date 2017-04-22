using UnityEngine;
using System.Collections;

public class life : MonoBehaviour {
    public float maxLife = 10;
    public float curLife = 10;
    public healthUI uiElement;

    private void Start() {
        if(uiElement)
            uiElement.SetHealth(curLife);
    }

    public void Update() {
        if(curLife > maxLife) {
            curLife = maxLife;
            if (uiElement)
                uiElement.SetHealth(curLife);
        }
    }

    public void takeDamage(int damage) {
        curLife -= damage;
        if(uiElement)
            uiElement.SetHealth(curLife);
    }

    public void healDamage(int life) {
        curLife += life;
        if(uiElement)
            uiElement.SetHealth(curLife);
    }
}
