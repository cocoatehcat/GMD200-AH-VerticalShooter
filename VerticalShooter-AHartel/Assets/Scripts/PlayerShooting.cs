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
    {  //Left click to fire
        if (Input.GetKeyDown(KeyCode.Mouse0))
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
        bullet.velocity = transform.up * 100;
        Destroy(bullet.gameObject, 1.0f);
    }
}
