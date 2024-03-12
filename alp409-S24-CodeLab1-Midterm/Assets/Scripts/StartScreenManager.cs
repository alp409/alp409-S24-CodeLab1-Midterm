using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class StartScreenManager : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField playerName;
    public TextMeshProUGUI gameOverText;

    private const string FILE_DIR = "/Data/";
    private const string DATA_FILE = "playerName.txt";
    private string FILE_PATH;

    private string savedPlayerName = "";
    
    // add script here to get player name from input field and save a txt file to data folder
    // reference that txt file in endGameName below
    
    public void enterName()
    {
        output.text = "Hello " + playerName.text + "\n Press Enter to Start";
        SavePlayerName(playerName.text);
    }

    private void SavePlayerName(string name)
    {
        FILE_PATH = Application.dataPath + FILE_DIR + DATA_FILE;

        //File.WriteAllText(FILE_PATH, name);
    }

    public void endGameName()  // TODO: fix it
    {
        output.text = "Good Game " + playerName.text;
    }
    
    // In start and end scene, press enter to go to game scene
    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return)) 
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
