using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForwardCube : MovingCube
{

    private void Start()
    {
        movingBehavior = gameObject.AddComponent<MovingForwardBehavior>() as MovingForwardBehavior;

    }

    public override void positionCheck(IMovingBehavior movingBehavior)
    {
        if (movingBehavior.transform.position.z > LastCube.transform.position.z)
        {
            float hangover = movingBehavior.transform.position.z - LastCube.transform.position.z;
            Debug.Log("Float from the MovingForwardCube is currently: " + hangover);
        }
    }

    public override void splitCube(float split)
    {
        throw new System.NotImplementedException();
    }
}
