using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///<summary>
/// MovingBehavior interface.
/// @author Dante
/// </summary>
public interface IMovingBehavior 
{
    Transform transform { get; }
    GameObject gameObject { get; }
    /// <summary>
    /// updatePostion of the object
    /// </summary>
    /// <param name="speed">float speed of movement.</param>
    void updatePosition(float speed);    

}
