using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public GameObject Mirror;
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
                if (hit.collider.gameObject.tag == "Point" )
                {
                    print( "object is clicked by mouse");
                    if(possibleRotation == Position.MirrorRotation.leftUp){
                        Instantiate(Mirror, hit.transform.position, Quaternion.Euler((int) possibleRotation,90,0));
                        hit.collider.gameObject.SetActive(false);
                    }

                    if(possibleRotation == Position.MirrorRotation.rightUp){
                        Instantiate(Mirror, hit.transform.position, Quaternion.Euler((int) possibleRotation,90,0));
                        hit.collider.gameObject.SetActive(false);
                    }
                }
            }
        }
    }

    void Update()
    {
        CheckClick();
    }
}
