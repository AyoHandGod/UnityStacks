using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForwardCube : MovingCube
{
    private void Start()
    {
        movingBehavior = gameObject.AddComponent<MovingForwardBehavior>() as MovingForwardBehavior;
    }
}
