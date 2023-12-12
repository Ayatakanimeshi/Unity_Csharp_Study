using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;

        while (a<100)
        {
            a += 20;
            Debug.Log("a+20"+ a);
        }
         
    }
}
