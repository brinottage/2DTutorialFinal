using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    [SerializeField] public float laserSpeed = .1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new UnityEngine.Vector3(0, laserSpeed, 0) * Time.deltaTime;

    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.tag == "Player") {

            // Calls the InitiateGameOver method if player
            GameManager.instance.DecreaseHealth(1);
            Destroy(gameObject);
        } else if (collision.gameObject.tag == "Barrier") {
            Destroy(gameObject);

        }

    
    }

}
