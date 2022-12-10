using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosX = 16.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2;
    private float spawnIntervalVertical = 3f;
    private float spawnIntervalHorizontalLeft = 3.5f;
    private float spawnIntervalHorizontalRight = 4f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalVertical", startDelay, spawnIntervalVertical);
        InvokeRepeating("SpawnRandomAnimalHorizontalLeft", startDelay, spawnIntervalHorizontalLeft);
        InvokeRepeating("SpawnRandomAnimalHorizontalRight", startDelay, spawnIntervalHorizontalRight);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalVertical()
    {
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalHorizontalLeft()
    {
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-22, 0, Random.Range(2, 12));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0f, 90f, 0f));
    }
    void SpawnRandomAnimalHorizontalRight()
    {
        //Randomly generate animal index and spawn position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(22, 0, Random.Range(2, 12));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0f, 270f, 0f));
    }
}
