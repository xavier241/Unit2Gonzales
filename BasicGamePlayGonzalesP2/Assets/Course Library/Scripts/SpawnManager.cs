using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float SpawnRangeX = 20;
    private float spawnposZ = 20;
    private float startdelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startdelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnRandomAnimal() 
    {
        int anaimalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, spawnposZ);

        Instantiate(animalPrefabs[anaimalIndex], spawnpos, animalPrefabs[anaimalIndex].transform.rotation);
    }
}
