using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public LineRenderer lineRenderer;
    public BoxCollider collider;
    public int CurrentIndex = 1; 
    private float test = 0f;
    public float Speed = 10f;

    float PrevX;
    float PrevY;
    float PrevZ;

    public enum varToUpdate
    {
        x,
        y,
        z,
    }
    public varToUpdate state;

    void Start()
    {
        CurrentIndex = 1;
    }

    void Update()
    {
        test += 0.1f * Time.deltaTime * Speed;
        
        if(state == varToUpdate.z)
        {
            lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX,PrevY,test));
            collider.center = new Vector3(0f, 0f, test);
        }
        if(state == varToUpdate.y)
        {
            lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX,PrevY -= (0.1f * Time.deltaTime * Speed),PrevZ));
            collider.center = new Vector3(PrevX, PrevY, PrevZ);
        }
        //transform.Translate(Vector3.forward * 1f * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        print("Collision");

        PrevX = lineRenderer.GetPosition(CurrentIndex).x;
        PrevY = lineRenderer.GetPosition(CurrentIndex).y;
        PrevZ = lineRenderer.GetPosition(CurrentIndex).z;

        lineRenderer.positionCount += 1;
        state = varToUpdate.y;
        //lineRenderer.SetPosition(lineRenderer.positionCount - 1, new Vector3(0, -1, 0));
        CurrentIndex += 1;
        //other.gameObject.transform.rotation = Quaternion.Euler(90,-90,0);
    }
}
