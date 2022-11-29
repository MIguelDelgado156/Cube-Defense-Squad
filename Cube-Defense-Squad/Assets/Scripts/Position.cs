using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Position : MonoBehaviour
{
    public GameObject Mirror;
    public GameObject NewMirror;
    private Reflect MirrorOrientation;
    public Toggle LeftButton;
    public Toggle RightButton;



    public enum MirrorRotation
    {
        leftUp = 45,
        rightUp = 135,
    }
    public MirrorRotation possibleRotation;

    void CheckClick(){
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit  hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.gameObject.tag == "Point")
                {
                    NewMirror = Instantiate(Mirror, hit.transform.position, Quaternion.Euler((int)possibleRotation, 90, 0));
                    MirrorOrientation = NewMirror.GetComponent<Reflect>();

                    if(possibleRotation == MirrorRotation.leftUp)
                        MirrorOrientation.currentOrientation = Reflect.ReflectState.LeftUP;

                    if(possibleRotation == MirrorRotation.rightUp)
                        MirrorOrientation.currentOrientation = Reflect.ReflectState.RightUP;

                    NewMirror.transform.parent = gameObject.transform.parent.transform;
                    hit.collider.gameObject.SetActive(false);
                }
                if (hit.collider.gameObject.tag == "Point_Face_1")
                {
                    NewMirror = Instantiate(Mirror, hit.transform.position, Quaternion.Euler((int)possibleRotation, 0, 0));
                    MirrorOrientation = NewMirror.GetComponent<Reflect>();

                    if(possibleRotation == MirrorRotation.leftUp)
                        MirrorOrientation.currentOrientation = Reflect.ReflectState.LeftUP;

                    if(possibleRotation == MirrorRotation.rightUp)
                        MirrorOrientation.currentOrientation = Reflect.ReflectState.RightUP;

                    NewMirror.transform.parent = gameObject.transform.parent.transform;
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }

    void Update()
    {
        CheckClick();
    }

    public void toggleLeftRotation()
    {
        possibleRotation = MirrorRotation.leftUp;
    }
    public void toggleRightRotation()
    {
        possibleRotation = MirrorRotation.rightUp;
    }

}
