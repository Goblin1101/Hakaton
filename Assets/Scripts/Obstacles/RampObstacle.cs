using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampObstacle : Obstacle
{
    ///TODO: разелить методы на отдельные интерфейсы
    public override void AcceptEnter(ObstacleVisitor visitor)
    {
        visitor.VisitRampObstacle(this);
    }

    public override void AcceptExit(ObstacleVisitor visitor)
    {
        visitor.VisitRampObstacleExit(this);
    }

    public override void AcceptStay(ObstacleVisitor visitor)
    {
        throw new System.NotImplementedException();
    }
}
