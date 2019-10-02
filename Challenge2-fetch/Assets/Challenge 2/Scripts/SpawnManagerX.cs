using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

        // InvokeRepeating was used originally, but does not allow spawnInterval to change
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);

        Invoke("SpawnRandomBall", 1.0f);

        Invoke("SpawnRandomBall", startDelay);

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);


        spawnInterval = Random.Range(0.1f, 5.0f);

        // Invoke again

        Invoke("SpawnRandomBall", spawnInterval);
    }

}
