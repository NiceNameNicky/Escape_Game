using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 3;

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
