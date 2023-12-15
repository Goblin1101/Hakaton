using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
    public abstract void AcceptEnter(ObstacleVisitor visitor);
    public abstract void AcceptStay(ObstacleVisitor visitor);
    public abstract void AcceptExit(ObstacleVisitor visitor);
}
