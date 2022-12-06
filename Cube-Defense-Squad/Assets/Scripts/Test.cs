using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Levels;
    void Awake()
    {
        // DontDestroyOnLoad(transform.gameObject);
    }

    public void completedLevel(int level){
        switch (level){
        case 1:
            StaticVars.Lvl1Complete = true;
            break;
        case 2:
            StaticVars.Lvl2Complete = true;
            break;
        case 3:
            StaticVars.Lvl3Complete = true;
            break;
        case 4:
            StaticVars.Lvl4Complete = true;
            break;
        case 5:
            StaticVars.Lvl5Complete = true;
            break;
        case 6:
            StaticVars.Lvl6Complete = true;
            break;
        }
        SaveSystem.Save();
    }
}
