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

            StartCoroutine(splitCube(hangover));
        }
    }

    public override IEnumerator splitCube(float split)
    {
        this.transform.localScale = new Vector3(-split, 0, 0);
        Debug.Log("Calling the splitCube method");
        yield return new WaitForEndOfFrame();
    }

    private void Start()
    {
        movingBehavior = gameObject.AddComponent<MovingRightBehavior>() as MovingRightBehavior;
    }


}
