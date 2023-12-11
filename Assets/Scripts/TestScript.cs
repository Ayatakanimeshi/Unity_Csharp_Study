using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 100;

        if(a == b)
        {
            Debug.Log("same");
        }
        else
        {
            Debug.Log("different");
        }

    }
}
