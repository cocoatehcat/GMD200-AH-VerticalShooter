using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Image[] heartImages;
    [SerializeField] private int numSegments = 4;
    private void OnEnable()
    {
        PlayerHealth.healthChanged += OnHealthChanged;
        OnHealthChanged(PlayerHealth.GetHealth());
    }

    private void OnDisable()
    {
        PlayerHealth.healthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(int obj)
    {
        //update UI visuals
        Debug.Log(message: "Health: " + obj);
        for (int i = 0; i < heartImages.Length; i++)
        {
            heartImages[i].fillAmount = (obj - i * numSegments) / (float)numSegments;
        }
    }

    void Update()
    {
        if (PlayerHealth.GetHealth() <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
