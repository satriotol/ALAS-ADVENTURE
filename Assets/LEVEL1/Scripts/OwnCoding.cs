using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class OwnCoding : MonoBehaviour
{
    public bool TrafficLightred;
    public LayerMask targetlayer;
    public Transform deteksilampu;
    public float jangkauan;
    public GameObject kalah;
    void start()
    {
    }

    void Update()
    {
        TrafficLightred = Physics2D.OverlapCircle(deteksilampu.position, jangkauan, targetlayer);


        if (TrafficLightred == true)
        {
            Debug.Log("Kena Gan");
            //SceneManager.LoadScene(0);
            kalah.SetActive(true);
        }
    }


}
