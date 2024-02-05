using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public static EnemyManager instance;
    private Coroutine _enemySpawn;

    void Start()
    {
        _enemySpawn = StartCoroutine(Co_SpawnEnemies());
    }

    //Spawns enemies after waiting for a specified amount of time
    IEnumerator Co_SpawnEnemies()
    {
        //Wave One
        for (int i = 0; i <= 13; i++) {
            var pos = new Vector2(Random.Range(-2.5f, 2.5f), 4.43f);
            Instantiate(enemyPrefab, pos, Quaternion.identity);
            yield return new WaitForSeconds(1.1f);
            var pos1 = new Vector2(Random.Range(-2.5f, 2.5f), 4.43f);
            Instantiate(enemyPrefab2, pos1, Quaternion.identity);
            yield return new WaitForSeconds(1.1f);
        }

        //Wave Two
        for (int i = 0; i <= 11; i++)
        {
            var pos2 = new Vector2(Random.Range(-2.5f, 2.5f), 4.43f);
            Instantiate(enemyPrefab, pos2, Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
            var pos3 = new Vector2(Random.Range(-2.5f, 2.5f), 4.43f);
            Instantiate(enemyPrefab2, pos3, Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
        }
        
        //Wave Three
        for (int i = 0; i <= 9; i++)
        {
            var pos3 = new Vector2(Random.Range(-2.5f, 2.5f), 4.43f);
            Instantiate(enemyPrefab, pos3, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            var pos4 = new Vector2(Random.Range(-2.5f, 2.5f), 4.43f);
            Instantiate(enemyPrefab2, pos4, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
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
