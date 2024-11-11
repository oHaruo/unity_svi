using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;

    float spawnTime;

    void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        spawnTime = spawnTime+Time.deltaTime;

        if (spawnTime > 0.2f)
        {
            Spawn();
            spawnTime = 0;
        }
    }

    void Spawn()
    {
        GameObject enemy = GameManager.instance.pool.Get(Random.Range(0, GameManager.instance.pool.prefabs.Length));
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].position;
        
    }
}
