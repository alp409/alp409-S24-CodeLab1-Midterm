using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        LevelLoader.instance.CurrentLevel++;
        Debug.Log("trigger");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
