using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleVisitor : MonoBehaviour
{
    ///TODO: �������� ������ �� ��������� ����������

    public abstract void VisitRampObstacle(RampObstacle rampObstacle);

    public abstract void VisitRampObstacleExit(RampObstacle rampObstacle);

    public abstract void VisitRampObstacleStay(RampObstacle rampObstacle);
    ///TODO: ����������� ������ ��������� ������ ��������
}
