using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public bool Charged;
    public bool Done;
    public GameObject Door;
    public GameObject WallEnd;

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
}
