using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConversation : MonoBehaviour
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
            //SceneManager.LoadScene(0);
            DialogueCanvas.SetActive(true);
        }
        else
        {
            DialogueCanvas.SetActive(false);
        }
    }
}
