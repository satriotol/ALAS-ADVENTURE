using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public float invulnPeriod = 2f;

    float invulnTimer = 0f;
    float invulnAnimTimer = 0;  
    int correctLayer;

    SpriteRenderer spriteRend;

    void Start()
    {
        correctLayer = gameObject.layer;

        spriteRend = GetComponent<SpriteRenderer>();

        if (spriteRend == null) 
        {
            spriteRend = transform.GetComponentInChildren<SpriteRenderer>();
            if (spriteRend == null) {
                Debug.LogError("Object '"+gameObject.name+"' has no sprite renderer");
            }
        }
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
        if (invulnTimer > 0) 
        {
            invulnTimer -= Time.deltaTime;

            if (invulnTimer <= 0)
            {
                gameObject.layer = correctLayer;
                if (spriteRend != null)
                {
                    spriteRend.enabled = true;
                }
            }
            else
            {
                if (spriteRend != null) 
                {
                    spriteRend.enabled = !spriteRend.enabled;
                }
            }
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
