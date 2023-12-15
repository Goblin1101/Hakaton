using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 shoot_dir;
    private float shoot_speed = 10f;

    public void Setup(Vector3 _shoot_dir)
    {
        shoot_dir = _shoot_dir;
        transform.eulerAngles = new Vector3(0,0,Utilities.GetAngleFromVectorFloat(shoot_dir));
        Destroy(gameObject,5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Surface"))
        {

        }
    }

    private void Update()
    {
        transform.position += shoot_speed * Time.deltaTime * shoot_dir;
    }








}
