using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    //fireRate is how often you can spawn a dog.
    public float fireRate = 0.5f;
    //nextFire serves as what the timer is counting down to.
    private float nextFire = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // If spacebar is pressed AND time elapsed > nextFire...
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            // Set nextFire to elapsed time + 0.5f

            // Example: If spacebar spawns at 6.0 seconds,
            // the next time it could spawn again would be at 6.5f seconds(6 + 0.5 = 6.5)
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
