using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBonus : MonoBehaviour
{
    public event Action BonusTakeHandler;
    public event Action BonusSpeedTakeHandler;
    public event Action BonusDeffenderTakeHandler;
    [SerializeField] private ParticleSystem _takeBonus;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bonus")
        {
            Destroy(collision.gameObject);
            BonusTakeHandler?.Invoke();
            _takeBonus.Play();
        }
        if(collision.gameObject.tag=="BonusSpeed")
        {
            Destroy(collision.gameObject);
            BonusSpeedTakeHandler?.Invoke();
        }
        if (collision.gameObject.tag == "BonusDeffend")
        {
            Destroy(collision.gameObject);
            BonusDeffenderTakeHandler?.Invoke();
        }
    }

   
}
