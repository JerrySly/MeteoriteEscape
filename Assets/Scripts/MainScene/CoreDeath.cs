using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CoreDeath : MonoBehaviour
{
    [SerializeField] private Button _restart;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Spawn spawnMeteors;
    [SerializeField] private BonusSpawn spawnBonus;
    public event Action DeathCore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            _restart.gameObject.SetActive(true);
            gameManager.StopAllCoroutines();
            spawnMeteors.StopAllCoroutines();
            spawnBonus.StopAllCoroutines();
            this.gameObject.SetActive(false);
            DeathCore?.Invoke();

        }

    }
}
