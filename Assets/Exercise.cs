using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{

    void Start()
    {
        int life = 3;
        while (life > 0)
        {
            if (life >= 3)
                Debug.Log("Many lives");
            else if (life == 1)
                Debug.Log("The last life!");

            life--;
        }

        Debug.Log("Game Over!");
    }   
    
}
