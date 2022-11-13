using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private move.Direction OriginalDirection;
    private move.varToUpdate OriginalVar;
    private GameObject OGline;

    // Start is called before the first frame update
    void Start()
    {
        OGline = this.transform.Find("Line").gameObject;
        OriginalDirection = OGline.GetComponent<move>().direction;
        OriginalVar = OGline.GetComponent<move>().state;
    }

    public GameObject line;
    public GameObject Oldline;
    public GameObject Newline;

    private Vector3 OriginalPosition;
    private Quaternion OriginalRoation;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            Oldline = this.transform.Find("Line").gameObject;
            OriginalPosition = Oldline.transform.position;
            OriginalRoation = Oldline.transform.rotation;


            Newline = Instantiate(line, OriginalPosition, OriginalRoation);
            Newline.GetComponent<move>().direction = OriginalDirection;
            Newline.GetComponent<move>().state = OriginalVar;
            Destroy(Oldline);
            Newline.transform.parent = gameObject.transform;
            Newline.name = "Line";
        }
    }
}
