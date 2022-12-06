using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_next : MonoBehaviour
{
    public GameObject Laser;
    public GameObject mainLaser;
    public bool ManualStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ManualStart)
            StartLaser();
    }

    public void StartLaser(){
        mainLaser.transform.GetChild(5).gameObject.GetComponent<move>().startFunc();
    }

    public void ResetLine(){
        Laser = mainLaser.transform.GetChild(5).gameObject;
        print(Laser);
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
