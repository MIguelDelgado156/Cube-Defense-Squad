using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public bool UP;
    public bool DOWN;
    public bool LEFT;
    public bool RIGHT;
    public bool Done;
    public bool OR;
    public float CurrRotX;
    public float CurrRotY;
    public float CurrRotZ;
    


    void RotateController()
    {
        if(Input.GetKeyDown(KeyCode.W) && Done)
        {
            UP = true;
            Done = false;
        }
        if(Input.GetKeyDown(KeyCode.A) && Done)
        {
            LEFT = true;
            Done = false;
            OR = true;
        }
        if(Input.GetKeyDown(KeyCode.S) && Done)
        {
            DOWN = true;
            Done = false;
        }
        if(Input.GetKeyDown(KeyCode.D) && Done)
        {
            RIGHT = true;
            Done = false;
            OR = true;
        }
    }

    void Rotation()
    {
        if(!LeanTween.isTweening(this.gameObject))
        {
            Done = true;
        }

        if(UP)
        {
            LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, CurrRotY, 0f), 1f);
            if(CurrRotX == 360f)
            {
                CurrRotX = 0;
            }
            UP = false;
        }

        if(DOWN)
        {
            LeanTween.rotate(this.gameObject, new Vector3(CurrRotX -= 90f, CurrRotY, 0f), 1f);
            if(CurrRotX == -360f)
            {
                CurrRotX = 0;
            }
            DOWN = false;
        }

        if(LEFT)
        {
            LeanTween.rotate(this.gameObject, new Vector3(CurrRotX, CurrRotY -= 90f, 0f), 1f);
            if(CurrRotY == -360f)
            {
                CurrRotY = 0;
            }
            if(CurrRotY == -180f || CurrRotY == 0f)
            {
                OR = false;
            }
            LEFT = false;
        }

        if(RIGHT)
        {
            LeanTween.rotate(this.gameObject, new Vector3(CurrRotX, CurrRotY += 90f, 0f), 1f);
            if(CurrRotY == 360f)
            {
                CurrRotY = 0;
            }
            if(CurrRotY == 180f || CurrRotY == 0f)
            {
                OR = false;
            }
            RIGHT = false;
        }

    }

    void Start()
    {
        UP = false;
        DOWN = false;
        RIGHT = false;
        LEFT = false;
        OR = false;
        CurrRotX = 0f;
        CurrRotY = 0f;
    }

    //void Update()
    //{
    //    RotateController();
    //    Rotation();
    //}
}
