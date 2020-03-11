using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int AmountBullets;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _radius;
    [SerializeField] private GameObject _magnitMeteorPrefab;
    public float StartValueForRandomTimeSpawn;
    public float EndValueForRandomTimeSpawn;
    public Deffend deffend;
    void Start()
    {
        new WaitForSeconds(1);
        StartCoroutine(SpawnWave());
        deffend.DestroyBulletHandler += IncountBullet;
    }


  public  IEnumerator SpawnWave()
    {
        while (AmountBullets <=10)
        {
            Vector3 posBullet = RandomCirclePosition();
            if(UnityEngine.Random.Range(0,10)>8)
            Instantiate(_magnitMeteorPrefab, posBullet, Quaternion.identity);
            else
            Instantiate(_bulletPrefab, posBullet,Quaternion.identity);
            AmountBullets++;
            float timeBetweenSpawn = UnityEngine.Random.Range(StartValueForRandomTimeSpawn, EndValueForRandomTimeSpawn);
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
   void IncountBullet()
    {
        AmountBullets--;
    }
}
