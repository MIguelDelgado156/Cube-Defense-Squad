using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        RotateController();
    }
    public GameObject target;
    void RotateController()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, this.transform.rotation.y, this.transform.rotation.z), 1f);
            transform.RotateAround(target.transform.position, Vector3.right, 20 * Time.deltaTime * 10f);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            //LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, this.transform.rotation.y, this.transform.rotation.z), 1f);
            this.transform.RotateAround(target.transform.position, Vector3.left, 20 * Time.deltaTime * 10f);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            //LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, this.transform.rotation.y, this.transform.rotation.z), 1f);
            this.transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime * 10f);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            //LeanTween.rotate(this.gameObject, new Vector3(CurrRotX += 90f, this.transform.rotation.y, this.transform.rotation.z), 1f);
            this.transform.RotateAround(target.transform.position, Vector3.down, 20 * Time.deltaTime * 10f);
        }
    }
}
