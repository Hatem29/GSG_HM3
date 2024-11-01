using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int ans = Multiply(5, i);
            Debug.Log(5 + " x " + i + " = " + ans);
        }
    }

    int Multiply(int a, int b)
    {
        return a * b;
    }

}
