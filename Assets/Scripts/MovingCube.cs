using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingCube : MonoBehaviour
{
    public static MovingCube CurrentCube { get; private set; }
    protected IMovingBehavior movingBehavior;

    [SerializeField]
    protected float moveSpeed = 1;

    protected void onEnable()
    {
        CurrentCube = this;
    }

    protected void Update()
    {
        moveForward(movingBehavior);
    }

    internal void Stop()
    {

    }

    public void moveForward(IMovingBehavior movingBehavior)
    {
        movingBehavior.updatePosition(this.moveSpeed);
    }

}
