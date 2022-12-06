using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [System.Serializable]
public class Data
{
    public bool level1;
    public bool level2;
    public bool level3;
    public bool level4;
    public bool level5;
    public bool level6;
    public float V;

    public Data () {
        level1 = StaticVars.Lvl1Complete;
        level2 = StaticVars.Lvl2Complete;
        level3 = StaticVars.Lvl3Complete;
        level4 = StaticVars.Lvl4Complete;
        level5 = StaticVars.Lvl5Complete;
        level6 = StaticVars.Lvl6Complete;
        V = StaticVars.volume;
    }
}
