using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBack : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject prefabBack;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<BackGroundBehave>())
        {
            Destroy(collision.gameObject);
            SpawnNewBack();
        }
    }
    private void SpawnNewBack()
    {
        Instantiate(prefabBack, spawnPoint.position, Quaternion.identity);
    }
}
