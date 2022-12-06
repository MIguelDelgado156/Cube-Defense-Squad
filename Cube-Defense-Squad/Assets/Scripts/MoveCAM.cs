using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCAM : MonoBehaviour
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
    public GameObject target;
    public Camera Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateController();
    }
    
    void RotateController()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, this.transform.rotation.y, this.transform.rotation.z), 1f);
            transform.RotateAround(target.transform.position, Camera.main.transform.right, 20 * Time.deltaTime * 10f);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            //LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, this.transform.rotation.y, this.transform.rotation.z), 1f);
            this.transform.RotateAround(target.transform.position, -Camera.main.transform.right, 20 * Time.deltaTime * 10f);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            //LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, this.transform.rotation.y, this.transform.rotation.z), 1f);
            this.transform.RotateAround(target.transform.position, Camera.main.transform.up, 20 * Time.deltaTime * 10f);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            //LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, this.transform.rotation.y, this.transform.rotation.z), 1f);
            this.transform.RotateAround(target.transform.position, -Camera.main.transform.up, 20 * Time.deltaTime * 10f);
        }
    }

}
