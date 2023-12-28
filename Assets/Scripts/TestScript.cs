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
        //x=1
        //y=10
        //z=100 
        TestObject.transform.Translate(1, 10, 100);
        TestObject.transform.Translate(1, 10, 100);

        TestObject.transform.localPosition = new Vector3(1.0f,10.0f,100.0f);
    }
}