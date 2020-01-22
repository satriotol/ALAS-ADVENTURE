using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject menulist;
    public Slider slider;

    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }
    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);
        menulist.SetActive(false);

        while (!operation.isDone)

        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            yield return null;
        }
    }
    public void LoadMenu()
    {
        Application.LoadLevel(0);
        Time.timeScale = 1f;
    }
    public void loadlevel3()
    {
        //Time.timeScale = 1f;
        Application.LoadLevel(4);
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
    public void Restartlevel2()
    {
        Application.LoadLevel(3);
    }
    public void Restartlevel3()
    {
        Application.LoadLevel(4);
    }
}
