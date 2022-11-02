using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public GameObject Mirror;
    public GameObject NewMirror;
    private Reflect MirrorOrientation;
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
                if (hit.collider.gameObject.tag == "LUPoint")
                {
                    possibleRotation = MirrorRotation.leftUp;
                    NewMirror = Instantiate(Mirror, hit.transform.position, Quaternion.Euler((int) possibleRotation,90,0));
                    MirrorOrientation = NewMirror.GetComponent<Reflect>();
                    MirrorOrientation.currentOrientation = Reflect.ReflectState.LeftUP;
                    hit.collider.gameObject.SetActive(false);
                }
                if(hit.collider.gameObject.tag == "RUPoint")
                {
                    possibleRotation = MirrorRotation.rightUp;
                    NewMirror = Instantiate(Mirror, hit.transform.position, Quaternion.Euler((int) possibleRotation,90,0));
                    MirrorOrientation = NewMirror.GetComponent<Reflect>();
                    MirrorOrientation.currentOrientation = Reflect.ReflectState.RightUP;
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }

    void Update()
    {
        CheckClick();
    }
}
