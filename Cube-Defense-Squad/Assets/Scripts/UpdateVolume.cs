using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateVolume : MonoBehaviour
{
    // Start is called before the first frame update
    public float V;
    void Awake()
    {
        if(SaveSystem.load() != null)
        {
            Data data = SaveSystem.load();
        
            StaticVars.Lvl1Complete = data.level1;
            StaticVars.Lvl2Complete = data.level2;
            StaticVars.Lvl3Complete = data.level3;
            StaticVars.Lvl4Complete = data.level4;
            StaticVars.Lvl5Complete = data.level5;
            StaticVars.Lvl6Complete = data.level6;
            StaticVars.volume = data.V;
        }

        V = StaticVars.volume;
        AudioListener.volume = StaticVars.volume;

    }

}
