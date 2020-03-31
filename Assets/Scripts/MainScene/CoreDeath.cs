using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class CoreDeath : MonoBehaviour
{
    [SerializeField] private Button _restart;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private Spawn _spawnMeteors;
    [SerializeField] private BonusSpawn _spawnBonus;
    [SerializeField] private SpawnBonusSpeed _spawnBonusSpeed;
    [SerializeField] private SpawnDeffenderBonus _spawnDeffenderBonus;
    public event Action DeathCore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            _restart.gameObject.SetActive(true);
            _gameManager.StopAllCoroutines();
            _spawnMeteors.StopAllCoroutines();
            _spawnBonus.StopAllCoroutines();
            _spawnBonusSpeed.StopAllCoroutines();
            _spawnDeffenderBonus.StopAllCoroutines();
            this.gameObject.SetActive(false);
            DeathCore?.Invoke();

        }

    }
}
