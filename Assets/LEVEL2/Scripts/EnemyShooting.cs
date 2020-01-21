using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject laserPrafab;

    public Vector3 laserOffset = new Vector3(0, 0.5f, 0);
    
    public float fireDelay = 0.50f;

    float cooldownTimer = 0;

    int laserLayer;

    void Start()
    {
        laserLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            Debug.Log("Pew!");
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * laserOffset;
            GameObject laserGO = (GameObject) Instantiate(laserPrafab, transform.position + offset, transform.rotation);
            laserGO.layer = laserLayer;
        }
    }
}
