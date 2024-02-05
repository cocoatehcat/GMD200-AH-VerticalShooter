using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagbullet : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    private Rigidbody2D rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.forward;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Damage");
        //GameObject gamecollid = collision.gameObject;
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(bullet.gameObject);
            player.GetComponent<PlayerTest>().takeDamage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
