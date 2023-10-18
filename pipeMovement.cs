using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement: MonoBehaviour
{
    public GameObject pipePrefab;
    public Transform bird;
    public float spawnInterval;
    public float spawnDelay;
    public float spawnDistance;
    public int score = 0;

    private float timeSinceLastSpawn;

    void Start()
    {
        timeSinceLastSpawn = 0;
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        spawnDelay -= (Time.deltaTime / 40);

        if (timeSinceLastSpawn > spawnInterval)
        {
            SpawnPipe();
            spawnInterval += spawnDelay;
        }
    }

    void AddScore()
    {
        score += 2;
    }

    void SpawnPipe()
    {
        score += 1;
        Vector3 spawnPosition = new Vector3(bird.position.x, 0, 0) + new Vector3(spawnDistance, Random.Range(-2f, 2f), 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        PlayerPrefs.SetInt("Score", score);
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 150, 30), ("Score: " + score.ToString()));
    }
}
