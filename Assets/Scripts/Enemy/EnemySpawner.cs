using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject      m_EnemyPrefab;


    [SerializeField]
    private float           m_EnemyInterval    = 4.5f;

    private void Start()
    {
        StartCoroutine(SpawnEnemy(m_EnemyInterval, m_EnemyPrefab));
    }
    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        Vector3 spawnPos = new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0);
        GameObject spawnobject = Instantiate(enemy, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }
}
