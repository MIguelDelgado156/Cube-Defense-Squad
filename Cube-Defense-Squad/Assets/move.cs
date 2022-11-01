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
    private Reflect MirrorOrientation;

    float PrevX;
    float PrevY;
    float PrevZ;

    Direction PrevDirection;

    public enum varToUpdate
    {
        x,
        y,
        z,
    }

    public enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public varToUpdate state;
    public Direction direction;

    void Start()
    {
        CurrentIndex = 1;
        PrevX = lineRenderer.GetPosition(CurrentIndex).x;
        PrevY = lineRenderer.GetPosition(CurrentIndex).y;
        PrevZ = lineRenderer.GetPosition(CurrentIndex).z;
    }

    void Update()
    {
        test += 0.1f * Time.deltaTime * Speed;

        if (state == varToUpdate.z)
        {
            lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX, PrevY, PrevZ += (0.1f * Time.deltaTime * Speed)));
            collider.center = new Vector3(0f, 0f, test);
        }
        if (state == varToUpdate.y)
        {
            lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX, PrevY += (0.1f * Time.deltaTime * Speed), PrevZ));
            collider.center = new Vector3(0f, test, 0f);
        }
        
        if (MirrorOrientation != null)
        {
            // All possible direction for left up
            if (state == varToUpdate.y && MirrorOrientation.currentOrientation == Reflect.ReflectState.LeftUP && PrevDirection == Direction.LEFT)
            {
                lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX, PrevY -= (0.1f * Time.deltaTime * Speed), PrevZ));
                collider.center = new Vector3(PrevX, PrevY, PrevZ);
                direction = Direction.DOWN;
            }
            if (state == varToUpdate.y && MirrorOrientation.currentOrientation == Reflect.ReflectState.LeftUP && PrevDirection == Direction.RIGHT)
            {
                lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX, PrevY += (0.1f * Time.deltaTime * Speed), PrevZ));
                collider.center = new Vector3(PrevX, PrevY, PrevZ);
                direction = Direction.UP;
            }
            if (state == varToUpdate.z && MirrorOrientation.currentOrientation == Reflect.ReflectState.LeftUP && PrevDirection == Direction.UP)
            {
                lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX, PrevY, PrevZ += (0.1f * Time.deltaTime * Speed)));
                collider.center = new Vector3(PrevX, PrevY, PrevZ);
                direction = Direction.RIGHT;
            }
            if (state == varToUpdate.z && MirrorOrientation.currentOrientation == Reflect.ReflectState.LeftUP && PrevDirection == Direction.DOWN)
            {
                lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX, PrevY, PrevZ += (0.1f * Time.deltaTime * Speed)));
                collider.center = new Vector3(PrevX, PrevY, PrevZ);
                direction = Direction.RIGHT;
            }

            //All possible directions for right up
            if (state == varToUpdate.z && MirrorOrientation.currentOrientation == Reflect.ReflectState.RightUP && PrevDirection == Direction.UP)
            {
                print("OOOOOOOOOOOOOOO");
                lineRenderer.SetPosition(CurrentIndex, new Vector3(PrevX, PrevY, PrevZ -= (0.1f * Time.deltaTime * Speed)));
                collider.center = new Vector3(PrevX, PrevY, PrevZ);
                //direction = Direction.LEFT;
            }
           
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print("Collision");
        MirrorOrientation = other.gameObject.GetComponent<Reflect>();
        PrevDirection = direction;

        PrevX = lineRenderer.GetPosition(CurrentIndex).x;
        PrevY = lineRenderer.GetPosition(CurrentIndex).y;
        PrevZ = lineRenderer.GetPosition(CurrentIndex).z;

        lineRenderer.positionCount += 1;
        if (direction == Direction.LEFT || direction == Direction.RIGHT)
        {
            state = varToUpdate.y;
        }
        if (direction == Direction.UP || direction == Direction.DOWN)
        {
            state = varToUpdate.z;
        }

        CurrentIndex += 1;
    }
}
