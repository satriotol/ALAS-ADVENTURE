﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacesPlayer : MonoBehaviour
{
    public Transform player;

    public float rotSpeed = 180f;

    // Update is called once per frame
    void Update()
    {
        if (player == null) 
        {
            GameObject gameObject = GameObject.FindWithTag("Player");

            if (gameObject != null) 
            {
                player = gameObject.transform;
            }
        }

        if (player == null) 
        {
            return;
        }

        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);
    }
}
