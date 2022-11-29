using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_next : MonoBehaviour
{
    public GameObject Laser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLaser(){
        Laser.GetComponent<move>().startFunc();
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if(other.gameObject.name == "Line"){
            print("WHY");
            StartLaser();
        }
    }
}
