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
        Debug.Log("position = " + TestObject.transform.localPosition);
        Debug.Log("kaiten = " + TestObject.transform.localEulerAngles);
        Debug.Log("scale = " + TestObject.transform.localScale);
    }
}