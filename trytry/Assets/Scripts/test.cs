using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class test : MonoBehaviour
{
    private string[] symbols = { "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne" };

    // Start is called before the first frame update
    void Start()
    {
        // Call a function to display the symbols
        Debug.Log("12345");
        DisplayAllSymbols();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for user input (e.g., 'q' key)
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Quit the application
            Application.Quit();
        }
    }

    // Function to display all symbols
    void DisplayAllSymbols()
    {
        // Loop through all symbols and print them
        for (int i = 0; i < symbols.Length; i++)
        {
            Debug.Log(symbols[i]);
        }

    }
}
