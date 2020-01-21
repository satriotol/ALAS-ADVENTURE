using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public int numLive = 5;

    GameObject playerInstance;

    float respawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();   
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInstance == null && numLive > 0) 
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0)
            {
                SpawnPlayer();
            }
        }
    }

    void SpawnPlayer()
    {
        numLive--;
        respawnTimer = 1f;
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "player";
    }

    void OnGUI()
    {
        if (numLive > 0 || playerInstance != null)
        {
            GUI.Label(new Rect(0, 0, 100, 50), "Lives: " + numLive);
        }
        else
        {
            GUI.Label(new Rect(Screen.width/2-50, Screen.height/2-25, 100, 50), "Game Over");
        }
        
    }
}
