using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI lvlDisplay;
    public TextMeshProUGUI timerDisplay;

    // remember: inInGame starts true because the GameManager isn't in the start scene
    private float timer = 0;
    public int maxTime = 60;
    private bool isInGame = true;

    public LevelLoader levelLoader; 
    
    // use GameManager as singleton for when isInGame = true 
    // GameManager will be destroyed when isInGame = false which happens when the timer runs out
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInGame)
        {
            // setting text for TMP
            lvlDisplay.text = "Level: " + levelLoader.currentLevel; 
            timerDisplay.text = "Time:" + (maxTime - (int)timer);            
        }
        else
        {
            // isInGame ends timer and destroys GameManger singleton
            isInGame = false;
            Destroy(gameObject);
            SceneManager.LoadScene("EndScene");
        }

        timer += Time.deltaTime;

        if (timer >= maxTime && isInGame)
        {
            isInGame = false;
            Destroy(gameObject);
            SceneManager.LoadScene("EndScene");
        }

    }
}
