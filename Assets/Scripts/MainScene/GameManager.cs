using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private Spawn spawnBehave;
    [SerializeField] private BulletBehave bulletBehave;
    [SerializeField] private MagnitMeteor magnitMeteor;
    [SerializeField] private float secondForNextDifficult;
    [SerializeField] private float startSpeedForBullet;
    [SerializeField] private float startValueForStartTimeSpawn;
    [SerializeField] private float minusSecondToStartTimeValue;
    [SerializeField] private float speedAdd;
    [SerializeField] private CoreDeath _core;
    private float secondTimeValue;
    [SerializeField]private static int _tryingToAdvert=3;
    private GameManager() { }
    public static GameManager GetInstance()
    {
        if (Instance == null)
            Instance = new GameManager();
        return Instance;
    }
    void Start()
    {
        secondTimeValue = minusSecondToStartTimeValue / 5;
        bulletBehave.Speed = startSpeedForBullet;
        spawnBehave.StartValueForRandomTimeSpawn = startValueForStartTimeSpawn;
        StartCoroutine(ChangingDifficult());
        _core.DeathCore += OnDeath;
        Advertisement.Initialize("3500014", false);
    }
    private void Update()
    {
        if (_tryingToAdvert <= 0)
            ShowAdv();
    }

    private void ShowAdv()
    {
        Advertisement.Show();
        _tryingToAdvert = 3;
    }

    public IEnumerator ChangingDifficult()
    {
        while (true)
        {
            if (UnityEngine.Random.Range(1, 3) == 1)
            {
                spawnBehave.StartValueForRandomTimeSpawn -= minusSecondToStartTimeValue;
                spawnBehave.EndValueForRandomTimeSpawn -= minusSecondToStartTimeValue;
                if (spawnBehave.StartValueForRandomTimeSpawn <= 1) minusSecondToStartTimeValue =secondTimeValue;
                if (spawnBehave.StartValueForRandomTimeSpawn <= 0.5) minusSecondToStartTimeValue = 0;
            }
            else 
            {
                bulletBehave.Speed += speedAdd;
                if (bulletBehave.Speed >= 24) speedAdd = 0;
            }
            yield return new WaitForSeconds(secondForNextDifficult);
        }
    }
    private void OnDeath()
    {
        _tryingToAdvert--;
    }
   
}
