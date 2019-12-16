using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonHandler:MonoBehaviour
{
    public bool isCorrect;
    public int value;

    public void Check() {

        if (isCorrect == true)
        {
            value = 1;
        }
        else
        {
            value = 0;
        }
    }

}

