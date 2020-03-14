using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    int hitPoints = 20;
    float speed = 3.8f;
    bool isAlive = true;
    string name = "Rick";
    int max;
    int min;

    void Start()
    {
        max = 1000;
        min = 1;
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number between " + min + " and " + max);
        Debug.Log(hitPoints);
        Debug.Log(speed);
        Debug.Log(isAlive);
        isAlive = false;
        Debug.Log(isAlive);
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
