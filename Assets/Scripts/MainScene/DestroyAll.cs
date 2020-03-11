using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAll : MonoBehaviour
{
    public delegate void _destroyBulletHandler();
    public event _destroyBulletHandler DestroyBulletHandler;
    public delegate void _destroyBonusHandler();
    public event _destroyBonusHandler DestroyBonusHandler;
    private void OnTriggerExit2D(Collider2D collision)
    {
        DestroyBullet(collision);
    }
    public void DestroyBullet(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            DestroyBulletHandler?.Invoke();

        }
        if (collision.gameObject.tag == "Bonus")
        {
            Destroy(collision.gameObject);
            DestroyBonusHandler?.Invoke();

        }
    }
}
