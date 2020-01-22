using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveSceneHouse : MonoBehaviour
{
    public bool movescene;
    public LayerMask targetlayer;
    public Transform deteksiscene;
    public float jangkauan;
    void Update()
    {
        movescene = Physics2D.OverlapCircle(deteksiscene.position, jangkauan, targetlayer);


        if (movescene == true)
        {
            Debug.Log("Kena Gan");
            SceneManager.LoadScene(5);
        }
    }
}
