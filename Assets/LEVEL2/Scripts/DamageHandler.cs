using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public float invulnPeriod = 2f;

    float invulnTimer = 0f;
    int correctLayer;

    void Start()
    {
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D() 
    {
        Debug.Log("Trigger!");

        health--;
        invulnTimer = invulnPeriod;

        gameObject.layer = 13;
    }

    void Update() 
    {

        invulnTimer -= Time.deltaTime;

        if (invulnTimer <= 0)
        {
            gameObject.layer = correctLayer;
        }

        if(health <= 0) 
        {
            Die();
        }
    }

    void Die() 
    {
        Destroy(gameObject); 
    }

   
}
