using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    // In start and end scene, press space to go to game scene
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            SceneManager.LoadScene("GameScene");
        }
        
        // TODO: add initials entry field
        // TODO: add score? number to end scene with initials
    }
}
