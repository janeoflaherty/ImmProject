using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaweedSpawnManager : MonoBehaviour
{
    public GameObject seaweedPrefab;
    public float spawnInterval = 5f; // Time between spawns
    public Vector3 spawnArea = new Vector3(10, 0, 10); // Area to spawn in

    void Start()
    {
        StartCoroutine(SpawnSeaweed());
    }

    IEnumerator SpawnSeaweed()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnArea.x, spawnArea.x),
                spawnArea.y,
                Random.Range(-spawnArea.z, spawnArea.z)
            );

            Instantiate(seaweedPrefab, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

