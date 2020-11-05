using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
        int min;
        int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number:");
        Debug.Log("Hughest number is");
        Debug.Log("Last example is: "+ max);
        Debug.Log("The last number examples is "+ min);
        max = max +1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {  
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
            StartGame(); 
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Higher or lower than: "+ guess);
    }
}
