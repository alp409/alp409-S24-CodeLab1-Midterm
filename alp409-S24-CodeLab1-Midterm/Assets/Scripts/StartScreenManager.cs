using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartScreenManager : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField playerName;
    //public TextMeshProUGUI gameOverText;

    public void enterName()
    {
        output.text = "Hello " + playerName.text + "\n Press Enter to Start";
    }

    public void endGameName()  // TODO: fix it
    {
        output.text = "Good Game " + playerName.text;
    }
    
    // In start and end scene, press space to go to game scene
    void Update()
    {
        if (Input.GetKey(KeyCode.Return)) 
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
