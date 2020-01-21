using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;

    float enemyRate1 = 5;
    float enemyRate2 = 5;

    float nextEnemy1 = 1;
    float nextEnemy2 = 1;

    float spawnDistance1 = 8f;
    float spawnDistance2 = 5f;
     
    // Update is called once per frame
    void Update()
    {
        nextEnemy1 -= Time.deltaTime;
        nextEnemy2 -= Time.deltaTime;

        if (nextEnemy1 <= 0)
        {
            nextEnemy1 = enemyRate1;
            enemyRate1 *= 0.9f;

            if (enemyRate1 < 2)
            {
                enemyRate1 = 2;
            }

            Vector3 offset1 = Random.onUnitSphere;
            offset1.z = 0;
            offset1 = offset1.normalized * spawnDistance1;
            Instantiate(enemyPrefab1, transform.position + offset1, Quaternion.identity);
            
        }

        if (nextEnemy2 <= 0)
        {
            nextEnemy2 = enemyRate2;
            enemyRate2 *= 1f;

            if (enemyRate2 < 2)
            {
                enemyRate2 = 2;
            }

            Vector3 offset2 = Random.onUnitSphere;
            offset2.z = 0;
            offset2 = offset2.normalized * spawnDistance2;
            Instantiate(enemyPrefab2, transform.position + offset2, Quaternion.identity);
        }
    }
}
