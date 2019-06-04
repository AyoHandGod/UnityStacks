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
        }
    }

    public override IEnumerator splitCube(float split)
    {
        this.transform.localScale = new Vector3(-split, 0, -split);
        yield return new WaitForEndOfFrame();
        this.transform.localScale = new Vector3(-split, 0, -split);
    }
}
