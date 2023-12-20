using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //????= new???[??????];

    void Start()
    {
        int[] scoreArray = new int[16];

        for (int i = 0; i < scoreArray.Length; i++)
        {
            scoreArray[i] = i * 20;
            Debug.Log("number is" +i+ "to" + scoreArray[i]);
        }
    }
}
