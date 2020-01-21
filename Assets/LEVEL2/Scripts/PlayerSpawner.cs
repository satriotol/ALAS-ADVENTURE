using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSpawner : MonoBehaviour
{
    Text text_lives;

    public GameObject playerPrefab;
    public int numLive = 5;

    GameObject playerInstance;

    float respawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        text_lives = GameObject.Find("TextLives").GetComponent<Text>();
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
        playerInstance.name = "playerShip";
    }

    void OnGUI()
    {
        if (numLive > 0 || playerInstance != null)
        {
            //GUI.Label(new Rect(0, 0, 100, 50), "Lives: " + numLive);
            text_lives.text = "Lives: " + numLive.ToString();
        }
        else
        {
            GUI.Label(new Rect(Screen.width/2-50, Screen.height/2-25, 100, 50), "Game Over");
        }
        
    }
}
