using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAccelUpScript : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float laserSpeedBoost = .1f;

    public Laser laser;
 
    void Start()
    {
        
    }
 

    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Increase laser speed
            laser.laserSpeed += laserSpeedBoost;
            

            Destroy(gameObject);
        } else if (collision.gameObject.tag == "Barrier") {
            Destroy(gameObject);
        }
    }
}
