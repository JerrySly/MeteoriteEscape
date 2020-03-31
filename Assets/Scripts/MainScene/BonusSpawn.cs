using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawn : MonoBehaviour
{
    [SerializeField] private int _amountBonus;
    [SerializeField] private GameObject _bonusPrefab;
    [SerializeField] private float _radius;
    public float StartValueForRandomTimeSpawn;
    public float EndValueForRandomTimeSpawn;
    [SerializeField] private Deffend _deffend;
    [SerializeField] private TakeBonus _takeBonus;
    
    void Start()
    {
        new WaitForSeconds(2);
        StartCoroutine(SpawnWave());
        _deffend.DestroyBonusHandler += IncountBonus;
        _takeBonus.BonusTakeHandler += IncountBonus;

    }


 public   IEnumerator SpawnWave()
    {
        float timeBetweenSpawn = Random.Range(StartValueForRandomTimeSpawn, EndValueForRandomTimeSpawn);
        yield return new WaitForSeconds(timeBetweenSpawn);
        while (_amountBonus <= 2)
        {
            Vector3 posBullet = RandomCirclePosition();
            Instantiate(_bonusPrefab, posBullet, Quaternion.FromToRotation(Vector3.zero, transform.position));
            _amountBonus++;
            timeBetweenSpawn = Random.Range(StartValueForRandomTimeSpawn, EndValueForRandomTimeSpawn);
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
    void IncountBonus()
    {
        _amountBonus--;
    }
}
