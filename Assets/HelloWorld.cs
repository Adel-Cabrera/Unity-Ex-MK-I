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
    int guess;


    void Start()
    {
        StartGame();
    }

    void StartGame() {

        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number between " + min + " and " + max);
        Debug.Log(hitPoints);
        Debug.Log(speed);
        Debug.Log(isAlive);
        isAlive = false;
        Debug.Log(isAlive);
        Debug.Log(name);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Up arrow = higher | Low arrow = lower. Press ENTER = correct");
        max = max + 1;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow");
            min = guess;
            NextGuess();

        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow");
            max = guess;
            NextGuess();

        }

        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter");
            StartGame();
        }
        
    }

    void NextGuess(){
        guess = (max + min / 2);
        Debug.Log("H or L than " + guess);

    }
}
