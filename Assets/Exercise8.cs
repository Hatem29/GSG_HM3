using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        int r;
        while (true) {
            r = UnityEngine.Random.Range(0, 20);

            if (r == 5)
                continue;
            else if (r == 15)
                break;

            Debug.Log(r);
        } 
    }

}
