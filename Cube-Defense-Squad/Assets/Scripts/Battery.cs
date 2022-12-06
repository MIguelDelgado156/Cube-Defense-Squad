using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public BoxCollider collider;

    public GameObject Line;
    public int Charge = 0;

    void Awake()
    {
        Line = GameObject.Find("Line");
    }

    void update()
    {
        //Battery Fully charged
        if (Charge == 5)
        {
            //other.gameObject.tag.Door += 0.1f * Time.deltaTime * Speed;
        }

    }
}
