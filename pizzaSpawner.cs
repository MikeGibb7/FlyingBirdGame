using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizzaSpawner : MonoBehaviour
{
    public GameObject pizzaPrefab;
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
            SpawnPizza ();
            spawnInterval += Random.Range(6, 10);
        }
    }

    void SpawnPizza ()
    {
        Vector3 spawnPosition = new Vector3(bird.position.x, 0, 0) + new Vector3(spawnDistance, Random.Range(-2f, 2f), 0);
        Instantiate(pizzaPrefab, spawnPosition, Quaternion.identity);
    }

}