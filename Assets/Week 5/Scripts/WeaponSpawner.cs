using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject spear;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnSpear()
    {
        Instantiate(spear, spawnPoint.position, spawnPoint.rotation);
    }
}
