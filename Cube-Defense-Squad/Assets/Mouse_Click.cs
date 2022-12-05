using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Click : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.GetComponent<AudioSource>().Play();
        }
    }
}
