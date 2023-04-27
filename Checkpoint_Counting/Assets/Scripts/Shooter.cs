using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject ballPrefab;
    public float ballSpeed = 10.0f;
    public GameObject spawnLoc;
    public GameObject shooter;
    public float rotationSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject ball = Instantiate(ballPrefab, spawnLoc.transform.position, Quaternion.identity);
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.velocity = transform.up * ballSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right arrow pressed");
            shooter.transform.Rotate(Vector3.right * 10f * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left arrow pressed");
            shooter.transform.Rotate(Vector3.right * -10f * rotationSpeed * Time.deltaTime);
        }
    }
}
