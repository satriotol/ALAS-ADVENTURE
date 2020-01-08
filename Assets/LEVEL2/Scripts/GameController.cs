using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController: MonoBehaviour {
    public static GameController instance;
    public GameObject gameOvertext;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    public Text scoreText;
    private int score = 0;

    public void BirdScored() {
        if (gameOver)
            return;
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    void Awake() {
        gameOvertext.SetActive(false);
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Update() {
        if (gameOver && Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdDied() {
        gameOvertext.SetActive(true);
        gameOver = true;
    }
}