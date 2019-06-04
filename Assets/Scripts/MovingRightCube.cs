using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRightCube : MovingCube
{
    public override void positionCheck(IMovingBehavior movingBehavior)
    {
        if(movingBehavior.transform.position.x < LastCube.transform.position.x)
        {
            float hangover = LastCube.transform.position.x - movingBehavior.transform.position.x;
            Debug.Log("Float From the MovingRightCube is currently: " + hangover);
        }
    }

    private void Start()
    {
        movingBehavior = gameObject.AddComponent<MovingRightBehavior>() as MovingRightBehavior;
    }


}
