using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeffenderBonus: MonoBehaviour
{

    [SerializeField] private GameObject _bonusDeffenderPref;
    [SerializeField] private float _radius;
    public float StartValueForRandomTimeSpawn;
    public float EndValueForRandomTimeSpawn;
    void Start()
    {
        new WaitForSeconds(1);
        StartCoroutine(SpawnWave());
    }
    


    public IEnumerator SpawnWave()
    {
        float timeBetweenSpawn = UnityEngine.Random.Range(StartValueForRandomTimeSpawn, EndValueForRandomTimeSpawn);
        yield return new WaitForSeconds(timeBetweenSpawn);
        while (true)
        {
            Vector3 posBullet = RandomCirclePosition();
            Instantiate(_bonusDeffenderPref, posBullet, Quaternion.identity);
            timeBetweenSpawn = UnityEngine.Random.Range(StartValueForRandomTimeSpawn, EndValueForRandomTimeSpawn);
            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
    Vector2 RandomCirclePosition()
    {
        float ang = UnityEngine.Random.value * 360;
        Vector2 position;
        position.x = transform.position.x + _radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        position.y = transform.position.y + _radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return position;
    }
}
