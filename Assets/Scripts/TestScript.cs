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


        b = a++;
        Debug.Log(b);

        b = ++a;
        Debug.Log(b);

    }
}
