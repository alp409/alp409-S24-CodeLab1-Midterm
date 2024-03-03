using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelLoader : MonoBehaviour
{
    int currentLevel = 0;
    GameObject level;

    public int CurrentLevel
    {
        get
        {
            return currentLevel;
        }
        
        set
        {
            currentLevel = value;
            LoadLevel();
            Debug.Log("Level: " + level);
        }
    }

    string FILE_PATH;

    public static LevelLoader instance;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
        FILE_PATH = Application.dataPath + "/Levels/LevelNum.txt";
        
        LoadLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLevel()
    {
        Destroy(level);
        
        level = new GameObject("Level Objects");
        
        //Get the lines from the file
        string[] lines = File.ReadAllLines(
            FILE_PATH.Replace("Num", currentLevel + ""));

        for (int yLevelPos = 0; yLevelPos < lines.Length; yLevelPos++)
        {

            //Debug.Log(lines[yLevelPos]);

            //Get a single line
            string line = lines[yLevelPos].ToUpper();

            //Turn line into a char array
            char[] characters = line.ToCharArray();

            for (int xLevelPos = 0; xLevelPos < characters.Length; xLevelPos++)
            {

                //get the first character
                char c = characters[xLevelPos];

                // Debug.Log(c);

                GameObject newObject = null;

                switch (c)
                {
                    case 'P': // player
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
                        break;
                    case 'W': // wall
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/Wall"));
                        break;
                    case 'X': // prize
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/Prize"));
                        break;
                    /*case 'H': // horizontal wall
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/Horizontal"));
                        break;
                    case 'V': // vertical wall
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/Vertical"));
                        break;*/
                    case 'B': // blue square
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/BlueSquare"));
                        break;
                    case 'R': // red square
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/RedSquare"));
                        break;
                    case 'Y': // blue square
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/YellowSquare"));
                        break;
                    default:
                        break;
                }

                if (newObject != null)
                {
                    newObject.transform.parent = level.transform;
                    //Give it a position based on where it was in the ASCII file
                    newObject.transform.position = new Vector2(xLevelPos, -yLevelPos);
                }
            }
        }
    }
}
