using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerL3Velocity : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody playerRb;
    public float horizontalBound = 10.0f;
    public float verticalBound = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // This code is from damonkeane2006 at https://answers.unity.com/questions/1379254/using-rigidbody-to-move-the-player.html
        playerRb.velocity = new Vector3(horizontalInput * speed, playerRb.velocity.y, verticalInput * speed);

        Debug.Log(verticalInput + " Vertical Input");
        Debug.Log(horizontalInput + " Horizontal Input");
    }

    void ConstrainPlayerPosition()
    {
        if (transform.position.x < -horizontalBound)
        {
            transform.position = new Vector3(-horizontalBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > horizontalBound)
        {
            transform.position = new Vector3(horizontalBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.z > verticalBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, verticalBound);
        }
        else if (transform.position.z < -verticalBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -verticalBound);
        }
    }
}
