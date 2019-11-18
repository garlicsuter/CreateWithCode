using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRange = 9.0f;

    // Start is called before the first frame update
    void Start()
    {
        float spawnPositionX = Random.Range(-spawnRange, spawnRange);
        float spawnPositionZ = Random.Range(-spawnRange, spawnRange);

        Vector3 spawnPos = new Vector3(spawnPositionX, 0, spawnPositionZ);

        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
