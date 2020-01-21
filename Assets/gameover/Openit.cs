using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Openit : MonoBehaviour

{
    public bool Win;
    public LayerMask targetlayer;
    public Transform deteksiwin;
    public float jangkauan;
    public GameObject DialogueCanvas;
    public AudioClip win,lose;

    AudioSource audio;


    void start ()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Win = Physics2D.OverlapCircle(deteksiwin.position, jangkauan, targetlayer);


        if (Win == true)
        {
            DialogueCanvas.SetActive(true);
            Time.timeScale = 0f;
            AudioListener.volume = 0f;
            SoundManager.PlaySound("win");
        }
        else
        {
            DialogueCanvas.SetActive(false);
            Time.timeScale = 1f;
            AudioListener.volume = 1f;
            SoundManager.PlaySound("win");
        }
    }
}
