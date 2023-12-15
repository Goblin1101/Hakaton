using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampObstacle : Obstacle
{
    public override void Accept(ObstacleVisitor visitor)
    {
        visitor.VisitRampObstacle(this);
    }
}
