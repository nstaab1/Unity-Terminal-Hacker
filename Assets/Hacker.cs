using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game State
    int level;
    enum Screen { MainMenu, Password, Win};
    enum Level { NewGame, Programming, Hockey, Space}
    string[] programmingPasswords = { "array", "object", "binary", "java", "variable" };
    string[] hockeyPasswords = { "stick", "puck", "goal", "slapshot", "check" };
    string[] spacePasswords = { "nebula", "spaceship", "blackhole", "asteroid", "gravity" };
    string password;
    Level currentLevel;
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
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    private void CheckPassword(string input)
    {
        if (input.ToLower() == password)
        {
            currentScreen = Screen.Win;
            RunWinScreen();
        }
        else
        {
            Terminal.WriteLine("Incorrect Password. Try Again.");
            StartGame();
        }
    }

    private void RunWinScreen()
    {
        password = "";
        currentLevel = Level.NewGame;
        Terminal.WriteLine("");
        Terminal.WriteLine("You are in!");
        Terminal.WriteLine("Type menu to try again");
    }

    void RunMainMenu(string input)
    {
        Terminal.ClearScreen();
        if (input == "1")
        {
            currentScreen = Screen.Password;
            currentLevel = Level.Programming;
            password = programmingPasswords[GenerateRandomNumber()];
            Terminal.WriteLine(password);
            StartGame();
        }
        else if (input == "2")
        {
            currentScreen = Screen.Password;
            currentLevel = Level.Hockey;
            password = hockeyPasswords[GenerateRandomNumber()];
            StartGame();
        }
        else if (input == "3")
        {
            currentScreen = Screen.Password;
            currentLevel = Level.Space;
            password = spacePasswords[GenerateRandomNumber()];
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
        Terminal.WriteLine("What is the password? ");
        Terminal.WriteLine(password.Anagram());
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

    private int GenerateRandomNumber()
    {
        System.Random randomNumber = new System.Random();
        return randomNumber.Next(0, 5);
    }
}
