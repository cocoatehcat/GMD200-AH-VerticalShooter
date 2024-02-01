using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
   [ContextMenu(itemName: "Damage")]

   public void takeDamage()
    {
        PlayerHealth.SetHealth(PlayerHealth.GetHealth() - 1);
    }

    
}
