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
    private Shooting _shooting;

    // Значение гравитации менять только 1 и -1, 0 не ставить, остальные в принципе всё равно
    // Это сделано, чтоб со стрельбой, да и вообще было проще
    private int gravity = 1;
    private void Awake()
    {
        _configuration = GetComponent<PlayerConfiguration>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _shooting = GetComponent<Shooting>();
    }

    private void Start()
    {
        Speed = _configuration.Speed;
    }

    private void FixedUpdate()
    {
        Debug.DrawLine(transform.position, new Vector3(0, 0.7f), Color.red);
        Move();

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Shoot();
        }

    }

    private void Move()
    {

        _xDirection = Input.GetAxis("Horizontal");

        var motion = new Vector2(_xDirection * Speed, _rigidbody.velocity.y);

        _rigidbody.velocity = motion;
    }
    
    private void Shoot()
    {
        _shooting.OnShooting(gravity);
    }
}
