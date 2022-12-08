using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    
    public int maxHealth = 10;
    public int health;
    public healthbar healthbar;

    void Start()
    {
        health = maxHealth;
        healthbar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        healthbar.Sethealth(health);
        if (health == 0) {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
