using UnityEngine;

[RequireComponent(typeof(PlayerObstacleVisitor))]
public class PlayerCollisionHandler : MonoBehaviour
{
    private PlayerObstacleVisitor _playerObstacleVisitor;

    private void Awake()
    {
        _playerObstacleVisitor = GetComponent<PlayerObstacleVisitor>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle component))
        {
            component.AcceptEnter(_playerObstacleVisitor);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle component))
        {
            component.AcceptExit(_playerObstacleVisitor);
        }
    }
}
