using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenarateEnemys : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int startingEnemyCount = 6;
    public int enemyIncrement = 2;
    public WaveCounter waveCounter;

    private int waveNumber = 0;
    private int enemyCount;

    //start de waves
    void Start()
    {
        enemyCount = startingEnemyCount;
        SpawnWave();
    }

    //controleerd of er nog enemies zijn
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            SpawnWave();
        }
    }

    //spawn de enemies en voegt +2 enemies toe per wave
    void SpawnWave()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            float xPos = Random.Range(200, 831);
            float zPos = Random.Range(162, 600);
            Vector3 spawnPos = new Vector3(xPos, 0, zPos);
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }

        waveCounter.UpdateWaveNumber();
        waveNumber++;
        enemyCount += enemyIncrement;
    }
}
