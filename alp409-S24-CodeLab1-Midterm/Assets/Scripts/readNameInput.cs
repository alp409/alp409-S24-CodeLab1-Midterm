using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readNameInput : MonoBehaviour
{
    private string nameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ReadStringInput(string s)
    {
        nameInput = s;
        Debug.Log(nameInput);
    }
}
