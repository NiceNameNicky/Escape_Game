using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 3;

    public Text playerHealthText;

    void Update()
    {
        HealthManagement();
    }

    public void HealthManagement()
    {
        if (playerHealth < 0)
        {
            playerHealth = 0;
        }
        else if (playerHealth == 0)
        {
            Death();
        }
        playerHealthText.text = "Health: " + playerHealth;
    }

    public void ApplyDamage()
    {
        playerHealth -= 1;
    }

    public void Death()
    {
        GetComponent<PlayerMovement>().Death();
    }
}
