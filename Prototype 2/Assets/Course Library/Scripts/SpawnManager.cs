using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public float spawnPosZ = 25.0f;
    public float spawnRangeX = 19.5f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()//At start, repeat method 
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

 
    void SpawnRandomAnimal() // Spawns animal from array in RangeX
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
