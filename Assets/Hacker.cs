using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game State
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnUserInput(string input)
    {
        if (input.ToLower() == "menu")
        {
            
            Terminal.ClearScreen();
            ShowMainMenu();
        }
        if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }

    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            currentScreen = Screen.Password;
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            currentScreen = Screen.Password;
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Invalid Respponse");
            ShowMainMenu();
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen level: " + level);
        print("You have chosen level: " + level);
    }

    private void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.WriteLine("1010010111010101010101010101010101");
        Terminal.WriteLine("Entering subdistrict databases Code:J934IUf");
        Terminal.WriteLine("Parsing drivers.....");
        Terminal.WriteLine("Choose Directory");
        Terminal.WriteLine("1: C:\\Programming");
        Terminal.WriteLine("2: C:\\Hockey");
        Terminal.WriteLine("3: C:\\Space");
    }

    private void ChooseDirectory()
    {

    }
}
