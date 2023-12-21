using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //????= new???[??????];
    float C(int ccc)
    {
        float number;

        number = ccc * 1.5f;

        return number;
    }

    void Start()
    {
        float x;

        x = C(5);

        Debug.Log(x);
    }
}
