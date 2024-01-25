using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private Coroutine _enemySpawn;

    void Start()
    {
        _enemySpawn = StartCoroutine(Co_SpawnEnemies());
    }

    //Spawns enemies after waiting for a specified amount of time
    IEnumerator Co_SpawnEnemies()
    {
        while (true)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StopCoroutine(Co_SpawnEnemies());
        }
    }
}