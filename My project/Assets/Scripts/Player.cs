using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

[SerializeField] GameObject laser;

[SerializeField] float HP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position in world space, but maintain the original z position
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.y = transform.position.y; // Maintain the original z position
        mousePosition.z = transform.position.z; // Maintain the original z position

        // Set the player's position to the mouse position
        transform.position = mousePosition;


        // Shoot laser
          // Quaternion identity is at the same rotation as the player       
        if (Input.GetButtonDown("FireLaser")) {
          Instantiate(laser, transform.position, Quaternion.identity);
        }
        
      }
}
