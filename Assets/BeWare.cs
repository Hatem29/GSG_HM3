using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeWare : MonoBehaviour
{
    void Start()
    {
        int human = 1, clown = 0;
        string answer = "if human was 1 and clown was 0, how much is clown x human?";
        Debug.Log(answer);
        Debug.Log("That's right.. ");
        Debug.Log(human * clown + "..");
        Debug.Log("only the clown is left.");

        Debug.LogWarning("RUN");
        Debug.LogError("NO DOOR!");
    }

}
