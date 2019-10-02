using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 40.0f;
    public float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Fixed Update is called once per physics frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");


        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward);
        transform.Translate(1, 0, 0);

        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); 

    }
}
