using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deffend : MonoBehaviour
{
    public delegate void _destroyBulletHandler();
    public event _destroyBulletHandler DestroyBulletHandler;
    public delegate void _destroyBonusHandler();
    public event _destroyBonusHandler DestroyBonusHandler;
    [SerializeField] private ParticleSystem _bulletDeath;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyBullet(collision);
    }
    public void DestroyBullet(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            DestroyBulletHandler?.Invoke();
            _bulletDeath.Play();
          
        }
        if (collision.gameObject.tag == "Bonus")
        {
            Destroy(collision.gameObject);
            DestroyBonusHandler?.Invoke();
          
        }
    } 


}
