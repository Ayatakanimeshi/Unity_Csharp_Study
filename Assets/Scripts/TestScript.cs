using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //List
    //????????????????

    private void Start()
    {
        int[] scoreArray = { 10, 20, 30, 40, 50 };

        foreach (int a in scoreArray)
        {
            Debug.Log(a);
        }
    }

}