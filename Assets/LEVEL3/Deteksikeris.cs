using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deteksikeris : MonoBehaviour
{
    public bool Conversation;
    public LayerMask targetlayer;
    public Transform deteksinpc;
    public float jangkauan;
    public GameObject DialogueCanvas;

    void Update()
    {
        Conversation = Physics2D.OverlapCircle(deteksinpc.position, jangkauan, targetlayer);


        if (Conversation == true)
        {
            Debug.Log("Kena Gan");
            DialogueCanvas.SetActive(true);
        }
        else
        {
            DialogueCanvas.SetActive(false);
        }
    }
}
