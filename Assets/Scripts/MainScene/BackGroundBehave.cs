using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundBehave : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(new Vector2(0,1) * Time.deltaTime * speed);
    }
}
