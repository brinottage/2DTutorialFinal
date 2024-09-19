using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;


public class Laser : MonoBehaviour
{

    [SerializeField] public float laserSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new UnityEngine.Vector3(0, laserSpeed, 0) * Time.deltaTime;
    }

}
