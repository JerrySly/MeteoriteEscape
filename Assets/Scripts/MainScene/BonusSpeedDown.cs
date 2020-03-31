using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeedDown : MonoBehaviour
{
    [SerializeField] private TakeBonus _takeBonus;
    [SerializeField] private BulletBehave _bulletBehave;
    [SerializeField] private float _valueSpeedDown;
    void Start()
    {
        _takeBonus.BonusSpeedTakeHandler += BulletSpeedDown;
    }

    void BulletSpeedDown()
    {
        _bulletBehave.Speed -= _valueSpeedDown;
    }
}
