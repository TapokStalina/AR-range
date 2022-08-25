using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _sphereRadius;
    [SerializeField] private float _secondsBetweenSpawn;
    [SerializeField] private Enemy[] _enemies;


    private void Start()
    {
        StartCoroutine(SpawnRandomEnemy());
    }
    private IEnumerator SpawnRandomEnemy()
    {
        while (true)
        {
            Enemy newEnemy = Instantiate(_enemies[Random.Range(0, _enemies.Length)], GetRandomSpawnPoint(_sphereRadius), Quaternion.identity);
            yield return new WaitForSeconds(_secondsBetweenSpawn);
        }
    }

    private Vector3 GetRandomSpawnPoint(float radius)
    {
        return Random.insideUnitSphere * radius;
    }
}
