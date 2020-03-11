using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBehave : MonoBehaviour
{
    public float Speed;
    private Vector2 _direction;

    private void Start()
    {
        _direction = new Vector2(Vector2.zero.x - transform.position.x, Vector2.zero.y - transform.position.y);
    }
    void Update()
    {
        Move();

    }



    private void Move()
    {
        transform.Translate(_direction * Time.deltaTime / 10 * Speed);
    }
}
