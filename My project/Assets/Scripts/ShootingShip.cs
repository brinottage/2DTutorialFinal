using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingShip : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    [SerializeField] GameManager manager;

    [SerializeField] GameObject laser;

    bool firedlaser;

    // Start is called before the first frame update
    void Start()
    {
        firedlaser = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;

        
        if (firedlaser == false) {
          Instantiate(laser, transform.position, Quaternion.identity);
          firedlaser = true;
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.tag == "Player") {

            // Calls the InitiateGameOver method if player
            GameManager.instance.DecreaseHealth(1);
            Destroy(gameObject);
        } else if (collision.gameObject.tag == "Barrier") {
            Destroy(gameObject);

        }
        else if (collision.gameObject.tag == "Laser"){

            // Increases Score if laser
             // Increases score by ten
            GameManager.instance.IncreaseScore(10);

            // Destroys the Enemy on collision
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

    
    }
}
