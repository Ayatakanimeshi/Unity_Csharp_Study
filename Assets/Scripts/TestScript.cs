using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (10 == 100)
        {
            Debug.Log("10 == 100 is true");
        }

        if (10 != 100)
        {
            Debug.Log("10 == 100 is true");
        }

        if (10 < 100)
        {
            Debug.Log("10 == 100 is true");
        }

        if (10 > 100)
        {
            Debug.Log("10 == 100 is true");
        }
    }
}
