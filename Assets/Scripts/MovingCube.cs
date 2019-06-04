using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingCube : MonoBehaviour
{
    public static MovingCube CurrentCube { get; private set; }
    public static MovingCube LastCube { get; private set; }

    [SerializeField]
    protected bool reversed;

    protected IMovingBehavior movingBehavior;

    [SerializeField]
    protected float moveSpeed = 1;

    protected void OnEnable()
    {
        if(LastCube == null)
            LastCube = GameObject.Find("Start Cube").GetComponent<MovingForwardCube>();

        Debug.Log(LastCube.ToString());

        if (reversed)
            moveSpeed *= -1;

        CurrentCube = this;
    }

    protected void Update()
    {
        moveForward(movingBehavior);
        positionCheck(movingBehavior);
    }

    internal void Stop()
    {
        moveSpeed = 0;
        float hangover = transform.position.z - LastCube.transform.position.z;
        Debug.Log(hangover);
    }

    public abstract void positionCheck(IMovingBehavior movingBehavior);

    public abstract void splitCube(float split);

    public void moveForward(IMovingBehavior movingBehavior)
    {
        movingBehavior.updatePosition(this.moveSpeed);
    }

}
