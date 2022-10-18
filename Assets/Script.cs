using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    private Coroutine ph;

    // Start is called before the first frame update
    private void Start()
    {
        ph = StartCoroutine(Message());
        StartCoroutine(UpTo30());
    }



    private IEnumerator Message()
    {
        WaitForSeconds wfs = new WaitForSeconds(4);
        while (true)
        {
            Debug.Log("Hello");
            yield return wfs;
        }
    }

    private IEnumerator UpTo30()
    {
        WaitForSeconds wfs = new WaitForSeconds(1);
        for (int i = 0; i <= 30; i ++)
        {
            Debug.Log($"{i}");
            yield return wfs;
        }
        StopCoroutine(ph);
    }
}
