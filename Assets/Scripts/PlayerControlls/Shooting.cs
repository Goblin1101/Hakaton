using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Vector3 shooting_pos;

    [SerializeField]
    private Transform pfBullet;
    

    void Update()
    {
        
        shooting_pos = transform.position + new Vector3(0,0.7f);
    }

    public void OnShooting(int up_or_down)
    {
        Transform bulletTransform = Instantiate(pfBullet, shooting_pos, Quaternion.identity);
        Vector2 shoot_dir = (Vector3.up * up_or_down).normalized;

        bulletTransform.GetComponent<Bullet>().Setup(shoot_dir);
    }

}
