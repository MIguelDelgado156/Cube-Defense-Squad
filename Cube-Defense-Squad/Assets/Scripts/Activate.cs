using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public bool Charged;
    public bool Done;
    public GameObject Door;
    public GameObject WallEnd;
    public GameObject WallStart;

    void Start()
    {
        Charged = false;
        Done = false;
    }

    void Update()
    {
        if (Charged && !Done)
        {
            LeanTween.move(Door, WallEnd.transform, 1f);
            Done = true;
        }
    }

    public void ResetWall()
    {
        LeanTween.move(Door, WallStart.transform, 1f);
        Done = false;
        Charged = false;
    }
}
