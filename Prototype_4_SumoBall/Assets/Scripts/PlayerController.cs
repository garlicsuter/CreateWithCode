using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody playerRb;
    private GameObject focalPoint;
    public bool hasPowerUp = false;
    public float powerUpStrength = 15;
    public GameObject powerupIndicator;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);

        powerupIndicator.transform.position = gameObject.transform.position + new Vector3(0, -0.5f, 0); ;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerUp = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
          
            StartCoroutine(PowerupCountdownroutine());
        }
    }

    IEnumerator PowerupCountdownroutine()
    {
        Debug.Log(Time.time);
        yield return new WaitForSeconds(5);
        hasPowerUp = false;
        powerupIndicator.gameObject.SetActive(false);
        Debug.Log(Time.time);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRb.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);

            Debug.Log("Collided with " + collision.gameObject.name + " powerup = " + hasPowerUp);

        }
    }
}
