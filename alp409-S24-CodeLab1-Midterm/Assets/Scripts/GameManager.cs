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
    // TODO: Add textmeshproUGUI to show timer and level number, maybe health too?

    private float timer = 0;
    public int maxTime = 60;
    private bool isInGame = true; // TODO: use this later for start and end screen
    
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
        // TODO: this doesn't really work, tried fixing execution order
        // TODO: need level as string, console shows game object
        // TODO: once this is fixed, add it to UGUI to show level
        // Debug.Log("level: " + LevelLoader.instance.CurrentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInGame)
        {
            lvlDisplay.text = "Level: X";
            timerDisplay.text = "Time:" + (maxTime - (int)timer);            
        }
        else
        {
            // TODO: end screen 
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
