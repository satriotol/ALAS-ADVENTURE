using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausebtn;
    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        pausebtn.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        pausebtn.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu  ()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(0);
    }
}