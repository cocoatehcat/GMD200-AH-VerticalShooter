using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(enemy.gameObject);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Score.IncreaseScore();
            Debug.Log(Score.GetScore());

            if (Score.GetScore() > 50)
            {
                SceneManager.LoadScene("French");
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Damage");
        //GameObject gamecollid = collision.gameObject;
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(enemy.gameObject);
            player.GetComponent<PlayerTest>().takeDamage();
        }
    }

}
