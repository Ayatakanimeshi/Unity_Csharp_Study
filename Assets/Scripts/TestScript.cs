using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //List
    //????????????????

    public GameObject TestObject;

    private void Start()
    {
        TestObject.transform.localScale = new(100.0f, 10.0f, 100.0f);
    }
}