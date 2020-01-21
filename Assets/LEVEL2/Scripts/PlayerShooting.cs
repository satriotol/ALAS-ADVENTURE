using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject laserPrefab1;
    public GameObject laserPrefab2;

    public Vector3 laserOffset1 = new Vector3(0.309f, 0.376f, 0);
    public Vector3 laserOffset2 = new Vector3(-0.309f, 0.376f, 0);

    public float fireDelay = 0.25f;

    float cooldownTimer = 0;

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= 0 )
        {
            // Shoot
            Debug.Log("Shoot!");
            cooldownTimer = fireDelay;

            Vector3 offset1 = transform.rotation * laserOffset1;
            Instantiate(laserPrefab1, transform.position + offset1, transform.rotation);

            Vector3 offset2 = transform.rotation * laserOffset2;
            Instantiate(laserPrefab2, transform.position + offset2, transform.rotation);
        }
    }
}
