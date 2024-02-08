using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class French : MonoBehaviour
{
    [SerializeField] private GameObject _french;
    public GameObject baguette;
    public Transform bagPos;

    private float timer;
    private int fHealth = 15;
 
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2)
        {
            timer = 0;
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(baguette, bagPos.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            fHealth -= 1;
            if (fHealth < 0)
            {
                Destroy(_french.gameObject);
                SceneManager.LoadScene("EndScene");
            }
        }
    }
}
