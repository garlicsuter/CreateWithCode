using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerL4 : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int animalIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0.6f, spawnPosZ);

        Instantiate(enemyPrefabs[animalIndex], spawnPos, enemyPrefabs[animalIndex].transform.rotation);
    }
}
