using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update

    int a = 1;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("i=" + i);

        }
    }
}
