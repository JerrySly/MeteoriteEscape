using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountPoints : MonoBehaviour
{
    [SerializeField] private int _amountPoints;
    [SerializeField] private TakeBonus takeBonus;
    void Start()
    {
        _amountPoints = 0;
        takeBonus.BonusTakeHandler += AddPoint;
    }
    private void AddPoint()
    {
        _amountPoints++;
    }
}
