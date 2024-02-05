using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public static EnemyManager instance;
    private Coroutine _enemySpawn;
    private bool waveOne = false;

    void Start()
    {
        waveOne = true;
        _enemySpawn = StartCoroutine(Co_SpawnEnemies());
    }

    //Spawns enemies after waiting for a specified amount of time
    //Re look at turotial to make different waves, 3 (60 secs) then 6 (120 secs) then French
    IEnumerator Co_SpawnEnemies()
    {
        while (waveOne == true)
        {
            var pos = new Vector2(Random.Range(-2.5f, 2.5f), 4.43f);
            Instantiate(enemyPrefab, pos, Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
            var pos1 = new Vector2(Random.Range(-2.5f, 2.5f), 4.43f);
            Instantiate(enemyPrefab2, pos1, Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
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
