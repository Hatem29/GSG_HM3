using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using UnityEngine;

public class Playerstuff : MonoBehaviour
{

    void Start()
    {
        // excercise 1
        int r;
        while (true) {
            r = UnityEngine.Random.Range(1, 20);

            if (r == 5)
                continue;
            else if (r == 15)
                break;

            Debug.Log(r);
        }


        // excercise 2

        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", 
            "Fish", "Tree", "Monkey", "Ball", "Bird" };

        string sentence = "";
        int c = 7;
        while(c-- > 0)
        {
            r = UnityEngine.Random.Range(0, words.Length - 1);
            sentence += words[r] + " ";
        }

        Debug.Log(sentence);
    }

}
