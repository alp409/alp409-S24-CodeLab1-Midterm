using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
//using UnityEngine.Windows;
using Input =  UnityEngine.Input;
using System.IO;

public class StartScreenManager : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField playerName;
    //public TextMeshProUGUI gameOverText;

    private const string FILE_DIR = "/Data/";
    private const string DATA_FILE = "playerName.txt";
    private string FILE_PATH;

    private string savedPlayerName = "";
    
    public void enterName()
    {
        output.text = "Hello " + playerName.text + "\n Press Enter to Start";
        SavePlayerName(playerName.text);
    }

    private void SavePlayerName(string name)
    {
        FILE_PATH = Application.dataPath + FILE_DIR + DATA_FILE;

        File.WriteAllText(FILE_PATH, name);
        Debug.Log("Name saved: " + name);
    }

    public void endGameName() // TODO: fix it
    {
        string savedName = ReadPlayerName();

        // enter player name into Good Game text here
        if (output != null)
        {
            output.text = "Game Over " + savedName + "\n Press Enter to Play Again";
        }
    }


    private string ReadPlayerName()
    {
        FILE_PATH = Application.dataPath + FILE_DIR + DATA_FILE;

        if (File.Exists(FILE_PATH))
        {
            string playerName = File.ReadAllText(FILE_PATH);
            return playerName;
        }
        else
        {
            return "";
        }
    }

    // In start and end scene, press enter to go to game scene
    void Update()
    {
        if (Input.GetKey(KeyCode.Return)) 
        {
            SceneManager.LoadScene("GameScene");
        }

        if (SceneManager.GetActiveScene().name == "EndScene")
        {
            endGameName();
        }
    }
}
