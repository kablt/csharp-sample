using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StringSlice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning Gold Rover Line";

        Debug.Log(greeting.Substring(0,10));
        Debug.Log(greeting.Substring(5));

        string[] arr = greeting.Split(new string[] {" "}, StringSplitOptions.None );

        foreach (string element in arr)
            Debug.Log($"{element}");
    }


}
