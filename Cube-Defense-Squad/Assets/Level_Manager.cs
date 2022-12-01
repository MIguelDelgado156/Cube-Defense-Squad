using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour
{
    public GameObject[] levels;
    // Start is called before the first frame update
    void Start()
    {
        if(StaticVars.Lvl1Complete)
            levels[0].SetActive(true);
        if(StaticVars.Lvl2Complete)
            levels[1].SetActive(true);
        if(StaticVars.Lvl3Complete)
            levels[2].SetActive(true);
        if(StaticVars.Lvl4Complete)
            levels[3].SetActive(true);
        if(StaticVars.Lvl5Complete)
            levels[4].SetActive(true);
        if(StaticVars.Lvl6Complete)
            levels[5].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
