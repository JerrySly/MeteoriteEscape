using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnitMeteor : MonoBehaviour
{
     private float _speed=1;
    [SerializeField] private float _acceleration;
    private Vector2 _direction;

    private void Start()
    {
        _direction = new Vector2(Vector2.zero.x - transform.position.x, Vector2.zero.y - transform.position.y);
        StartCoroutine(Accelerate());

    }
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_direction * Time.deltaTime / 10 * _speed);
    }
    IEnumerator Accelerate()
    {
        while (true)
        {
            _speed += _acceleration;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
