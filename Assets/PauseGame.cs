using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool GameIsPaused = true;


    void Update()
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
    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        AudioListener.volume = 1f;
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        AudioListener.volume = 1f;
    }
}