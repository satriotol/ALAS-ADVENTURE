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
    public static bool GameIsPaused = false;




    private void Update()
    {
        Win = Physics2D.OverlapCircle(deteksiwin.position, jangkauan, targetlayer);


        if (Win == true)
        {
            DialogueCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
