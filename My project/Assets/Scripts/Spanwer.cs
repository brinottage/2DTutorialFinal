using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanwer : MonoBehaviour
{

    [SerializeField] float enemySpawnRate = 2f;

    [SerializeField] float quickEnemySpawnRate = 2f;

    [SerializeField] float BASpawnRate = 2f;

    [SerializeField] float HealthSpawnRate = 2f;

    [SerializeField] GameObject enemyPrefab;

    [SerializeField] GameObject quickEnemyPrefab;

    [SerializeField] GameObject BulletAccelPrefab;

    [SerializeField] GameObject healthPrefab;
    
    float xMin;
    float xMax;
    float ySpawn;

    // Start is called before the first frame update
    void Start()
    {

        // Leftmost of the screen
        xMin = Camera.main.ViewportToWorldPoint(new Vector3(.1f, 0, 0)).x;

        // Rightmost of the screen
        xMax = Camera.main.ViewportToWorldPoint(new Vector3(.9f, 0, 0)).x;

        // 25% above the top of the screen. 1 is the top, .25 is the total height above that
        ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.25f, 0)).y;

        // Spawns enemies according to the spawn rate
        InvokeRepeating("SpawnEnemy", 0, enemySpawnRate);

         
        InvokeRepeating("SpawnBulletAccel", 0, BASpawnRate);

         
        InvokeRepeating("SpawnHealth", 0, HealthSpawnRate);

        InvokeRepeating("SpawnQuickEnemy", 0, quickEnemySpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {

        float randomX = Random.Range(xMin, xMax);
        // Spawns above the top of the sccreen
        Instantiate(enemyPrefab, new Vector3(randomX, ySpawn, 0), Quaternion.identity);
    }

    void SpawnQuickEnemy()
    {

        float randomX = Random.Range(xMin, xMax);
        // Spawns above the top of the sccreen
        Instantiate(quickEnemyPrefab, new Vector3(randomX, ySpawn, 0), Quaternion.identity);
    }

    void SpawnBulletAccel()
    {

        float randomX = Random.Range(xMin, xMax);
        // Spawns bullet accels above the top of the screen
        Instantiate(BulletAccelPrefab, new Vector3(randomX, ySpawn, 0), Quaternion.identity);
    }

    void SpawnHealth()
    {
        float randomX = Random.Range(xMin, xMax);
        // Spawns bullet accels above the top of the screen
        Instantiate(healthPrefab, new Vector3(randomX, ySpawn, 0), Quaternion.identity);
    }
}
