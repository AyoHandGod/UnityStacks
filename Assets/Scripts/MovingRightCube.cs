using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRightCube : MovingCube
{
    private void Start()
    {
        movingBehavior = gameObject.AddComponent<MovingRightBehavior>() as MovingRightBehavior;
    }

}
