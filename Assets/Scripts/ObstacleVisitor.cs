using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleVisitor : MonoBehaviour
{
    public abstract void VisitRampObstacle(RampObstacle rampObstacle);

    ///TODO: реализовать методы посещения других платформ
}
