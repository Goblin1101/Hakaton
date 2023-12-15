using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerConfiguration))]
public class PlayerObstacleVisitor : ObstacleVisitor
{
    [SerializeField]
    private float _slip = 2f;

    private PlayerMovement _playerMovement;

    private PlayerConfiguration _playerConfiguration;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Start()
    {
        _playerConfiguration = GetComponent<PlayerConfiguration>();
    }

    public override void VisitRampObstacle(RampObstacle rampObstacle)
    {
        _playerMovement.Speed = _playerConfiguration.Speed * _slip;
    }

    public override void VisitRampObstacleExit(RampObstacle rampObstacle)
    {
        _playerMovement.Speed = _playerConfiguration.Speed;
    }

    public override void VisitRampObstacleStay(RampObstacle rampObstacle)
    {
        
    }
}
