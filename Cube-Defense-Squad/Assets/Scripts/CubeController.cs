using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public bool Done = true;
    public string CurrAnim;
    void Start()
    {
        CurrAnim = "Cube_Rotation_Up";
    }

    void AnimationController()
    {
        if(GetComponent<Animation>()[CurrAnim].normalizedTime > 0.9)
        {
            Done = true;
        }
        if(Input.GetKeyDown(KeyCode.W) && Done)
        {
            GetComponent<Animation>().Play("Cube_Rotation_Up");
            CurrAnim = "Cube_Rotation_Up";
            Done = false;
        }
        if(Input.GetKeyDown(KeyCode.A) && Done)
        {
            GetComponent<Animation>().Play("Cube_Rotation_Left");
            CurrAnim = "Cube_Rotation_Left";
            Done = false;
        }
        if(Input.GetKeyDown(KeyCode.S) && Done)
        {
            GetComponent<Animation>().Play("Cube_Rotation_Down");
            CurrAnim = "Cube_Rotation_Down";
            Done = false;
        }
        if(Input.GetKeyDown(KeyCode.D) && Done)
        {
            GetComponent<Animation>().Play("Cube_Rotation_Right");
            CurrAnim = "Cube_Rotation_Right";
            Done = false;
        }
    }
    void Update()
    {
        AnimationController();
    }
}
