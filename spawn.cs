using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform bird;
    public float spawnInterval;
    public float spawnDistance;

    private float timeSinceLastSpawn;

    void Start()
    {
        timeSinceLastSpawn = 0;
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn > spawnInterval)
        {
            SpawnLaser();
            spawnInterval += Random.Range(2,5);
        }
    }

    void SpawnLaser()
    {
        Vector3 spawnPosition = new Vector3(bird.position.x, 0, 0) + new Vector3(spawnDistance, Random.Range(-2f, 2f), 0);
        Instantiate(laserPrefab, spawnPosition, Quaternion.identity);
    }

}
