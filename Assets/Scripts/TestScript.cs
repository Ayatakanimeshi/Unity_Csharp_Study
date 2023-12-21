using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //??????????
    //??????????????????????

    void Start()
    {
        float targetNumber = 11.5f;

        float floorResult = Mathf.Floor(targetNumber);
        Debug.Log(floorResult);

        float ceilResult = Mathf.Ceil(targetNumber);
        Debug.Log(ceilResult);

        float roundResult = Mathf.Round(targetNumber);
        Debug.Log(roundResult);
    }
}
