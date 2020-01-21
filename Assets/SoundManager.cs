using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip winsound, losesound;
    static AudioSource audioSource;
    
    void start()
    {
        winsound = Resources.Load<AudioClip>("win");
        losesound = Resources.Load<AudioClip>("lose");

        audioSource = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "winsound":
                audioSource.PlayOneShot(winsound);
                break;
            case "losesound":
                audioSource.PlayOneShot(winsound);
                break;
        }
    }
}
