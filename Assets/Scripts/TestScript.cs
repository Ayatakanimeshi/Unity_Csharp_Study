using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public enum ACTION_TYPE
    {
        JUMP,
        ATTACK,
        DEFENCE
    }

    private void Start()
    {
        ACTION_TYPE actionType;

        actionType = ACTION_TYPE.JUMP;

        switch (actionType)
        {
            case ACTION_TYPE.JUMP:
                //jump
                Debug.Log("jump");
                break;

            case ACTION_TYPE.ATTACK:
                //attack
                break;

            case ACTION_TYPE.DEFENCE:
                //defence
                break;
        }
    }
}
