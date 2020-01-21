﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(0);
    }
    public void loadlevel3()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(3);
    }
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame ()
    {
        Debug.Log("Quit!!");
        Application.Quit();
    }
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}