using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = 700;

        if(score < 500)
        {
            Debug.Log("Brank");
        }
        else if(score < 1000)
        {
            Debug.Log("Arank");
        }
        else
        {
            Debug.Log("Srank");
        }

    }
}
