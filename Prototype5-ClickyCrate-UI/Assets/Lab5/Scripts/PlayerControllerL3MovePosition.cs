using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerL3MovePosition : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody playerRb;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.MovePosition(transform.position + (Vector3.right * speed * horizontalInput));
        playerRb.MovePosition(transform.position + (Vector3.forward * speed * verticalInput));

        //playerRb.MovePosition(Vector3.right * speed * horizontalInput);
        //playerRb.MovePosition(Vector3.forward * speed * verticalInput);

        //Debug.Log(verticalInput + " Vertical Input");
        //Debug.Log(horizontalInput + " Horizontal Input");
    }
}
