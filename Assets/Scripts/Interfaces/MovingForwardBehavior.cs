using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForwardBehavior : MonoBehaviour, IMovingBehavior
{
    public void updatePosition(float speed)
    {
        GameObject gameObject = base.gameObject;
        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * speed;
    }

}
