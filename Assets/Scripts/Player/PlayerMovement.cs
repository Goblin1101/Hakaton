using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerConfiguration))]
public class PlayerMovement : MonoBehaviour
{
    [field: SerializeField]
    public float Speed { get; set; }

    private PlayerConfiguration _configuration;

    private Rigidbody2D _rigidbody;
    private float _xDirection = 0;


    private void Awake()
    {
        _configuration = GetComponent<PlayerConfiguration>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Speed = _configuration.Speed;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _xDirection = Input.GetAxis("Horizontal");

        var motion = new Vector2(_xDirection * Speed, _rigidbody.velocity.y);

        _rigidbody.velocity = motion;
    }
}
