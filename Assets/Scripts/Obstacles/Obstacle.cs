using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacle : MonoBehaviour
{
    public abstract void Accept(ObstacleVisitor visitor);
}
