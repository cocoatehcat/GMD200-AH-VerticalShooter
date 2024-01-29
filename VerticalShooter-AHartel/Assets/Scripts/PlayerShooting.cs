using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifetime;
    // Update is called once per frame
    void Update()
    {  //Find what left mouse click is
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        //Mouse Aiming
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = transform.position.z;
        transform.up = mouseWorldPos - transform.position;
    }

    private void Fire()
    {
        //shoot bullet
        Rigidbody2D bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.velocity = Vector2.up * 100;
        Destroy(bullet.gameObject, 1.0f);
    }
}
