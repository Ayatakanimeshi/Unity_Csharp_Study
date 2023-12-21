using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        D(ddd2:"hello", ddd3: 0.5f, ddd1: 100);
    }

    void D(int ddd1,string ddd2,float ddd3)
    {
        Debug.Log(ddd1);
        Debug.Log(ddd2);
        Debug.Log(ddd3);
    }
}
