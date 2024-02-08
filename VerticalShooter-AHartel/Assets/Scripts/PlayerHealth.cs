using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class PlayerHealth
{
    public static event Action<int> healthChanged;
    private static int _health = 12;
    public static void SetHealth(int health)
    {
        if (_health == health)
        {
            return;
        }
        _health = health;
        healthChanged?.Invoke(_health);
    }

    public static int GetHealth()
    {
        return _health;
    }

}
