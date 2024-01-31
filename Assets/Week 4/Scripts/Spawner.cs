using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Plane;
    public Transform spawner;
    float timer = 0;
    float spawnTime;
    float lastTime;
    Vector3 spawnPosition;
    
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
        if (timer - lastTime > spawnTime)
        {
            SpawnPlane();
            Debug.Log("plane");
            SpawnTime();
        }
    }

    void SpawnPlane()
    {
        spawnPosition.x = Random.Range(- 5, 5);
        spawnPosition.y = Random.Range(-5, 5);
        spawnPosition.z = 0;
        float spawnRotation = Random.Range(0, 360);
        Instantiate(Plane, spawnPosition, Quaternion.Euler(0, 0, spawnRotation));
        lastTime = timer;
    }

    void SpawnTime()
    {
        spawnTime = Random.Range(1, 5);
        
    }
}
