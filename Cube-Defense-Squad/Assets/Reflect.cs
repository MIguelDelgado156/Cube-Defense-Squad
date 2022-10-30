using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect : MonoBehaviour
{
    // Start is called before the first frame updat

    public int CurrentIndex = 1;
    public GameObject Line;

    void Awake()
    {
        Line = GameObject.Find("Line");
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     print("Collision");
    //     LineRenderer lr = other.gameObject.GetComponent<LineRenderer>();
    //     move ls = Line.GetComponent<move>();
    //     lr.positionCount += 1;
    //     print(lr.GetPosition(0));
    //     lr.SetPosition(lr.positionCount - 1, new Vector3(-1, -1, 0));
    //     ls.CurrentIndex += 1;
    //     //other.gameObject.transform.rotation = Quaternion.Euler(90,-90,0);
    // }
}
