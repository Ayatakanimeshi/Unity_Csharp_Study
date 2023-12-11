using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 2;

        switch (a)
        {
            case 0:
                Debug.Log("jikkou");
                break;

            case 1:
                Debug.Log("jikkou1");
                break;

            case 2:
                Debug.Log("jikkou2");
                break;

            case 3:
                Debug.Log("jikkou3");
                break;

            default:
                Debug.Log("default");
                break;
        }
    }
}
