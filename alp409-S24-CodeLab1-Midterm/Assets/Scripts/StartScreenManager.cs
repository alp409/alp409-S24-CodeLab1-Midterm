using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    //public string nameInput;
    // In start and end scene, press space to go to game scene
    void Update()
    {
        if (Input.GetKey(KeyCode.Return)) 
        {
            SceneManager.LoadScene("GameScene");
        }
        
        // TODO: add initials entry field
        // TODO: add score? number to end scene with initials
    }

    /*public void ReadStringInput(string s)
    {
        nameInput = s;
        Debug.Log(nameInput);
    }*/
}
