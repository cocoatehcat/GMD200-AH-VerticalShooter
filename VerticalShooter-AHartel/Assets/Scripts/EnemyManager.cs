using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public static EnemyManager instance;
    private Coroutine _enemySpawn;
    private bool waveOne = false;
    private bool waveTwo = false;
    private bool waveThree = false;

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
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
        while (waveTwo == true)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }

        while(waveThree == true)
        {
            //impliment French
        }
    }

    public int CheckWave()
    {
        if (waveOne == true)
        {
            return 1;
        }
        if (waveTwo == true)
        {
            return 2;
        }
        if (waveThree == true)
        {
            return 3;
        }
        return 0;
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
