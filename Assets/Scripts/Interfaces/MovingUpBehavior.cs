using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUpBehavior : MonoBehaviour, IMovingBehavior
{
    public void updatePosition(float speed)
    {
        GameObject gameObject = base.gameObject;
        gameObject.transform.position += gameObject.transform.up * Time.deltaTime * speed;
    }
}
