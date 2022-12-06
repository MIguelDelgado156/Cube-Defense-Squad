using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private move.Direction OriginalDirection;
    private move.varToUpdate OriginalVar;
    private GameObject OGline;
    public GameObject Newline;
    public GameObject Points;

    // Start is called before the first frame update
    void Start()
    {
        OGline = this.transform.Find("Line").gameObject;
        OriginalDirection = OGline.GetComponent<move>().direction;
        OriginalVar = OGline.GetComponent<move>().state;
        Newline = OGline;
    }

    public GameObject line;
    public GameObject Oldline;

    private Vector3 OriginalPosition;
    private Quaternion OriginalRoation;
    public void ResetGame()
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

        foreach (Transform child in Points.transform)
        {
            if (child.tag == "Point" || child.tag == "Point_Face_1" || child.tag == "Point_Face_2" || child.tag == "Point_Face_3" || child.tag == "Point_Face_4" || child.tag == "Point_Face_5")
            {
                child.gameObject.SetActive(true);
            }
            if (child.tag == "Mirror")
            {
                Destroy(child.gameObject);
            }
        }
    }

    public void StartGame()
    {
        foreach (Transform child in Points.transform)
        {
            if (child.tag == "Point" || child.tag == "Point_Face_1" || child.tag == "Point_Face_2" || child.tag == "Point_Face_3" || child.tag == "Point_Face_4" || child.tag == "Point_Face_5")
            {
                child.gameObject.SetActive(false);
            }
        }
        Newline.GetComponent<move>().startFunc();
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
