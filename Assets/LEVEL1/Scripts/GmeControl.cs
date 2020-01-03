using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GmeControl : MonoBehaviour
{
    public GameObject green;
    public GameObject red;

    /*IEnumerator Start()
    {
        yield return StartCoroutine(WaitAndPrint(10.0f));
    }
    */
    void Start()
    {
        StartCoroutine(WaitAndPrint());
    }
    IEnumerator WaitAndPrint()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            red.SetActive(false);
            green.SetActive(true);
            yield return new WaitForSeconds(5f);
            red.SetActive(true);
            green.SetActive(false);

        }

    }
    /*public void Enable()
    {
        green.SetActive(true);
    }
    public void Disable()
    {
        green.SetActive(false);
    }
    */
}
