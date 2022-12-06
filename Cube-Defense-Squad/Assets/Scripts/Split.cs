using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    public GameObject[] points;
    private GameObject[] PointOGS;

    private move.Direction[] OriginalDirection;
    private move.varToUpdate[] OriginalVar;
    private Vector3 OriginalPosition;
    private Quaternion OriginalRoation;
    public GameObject Newline;
    public int index = 0;

    void OnTriggerEnter(Collider other)
    {
        print("HELLO");
        foreach (GameObject child in points){
            child.GetComponent<move>().startFunc();
        }
    }
}