using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public int playerHealth;

    [SerializeField] private Image[] hearts;

    timer timer1;

    
    private void Start()
    {
        UpdateHealth();
        Time.timeScale = 1f;
    }

    public void UpdateHealth()
    {
     
     
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)
            {
                hearts[i].color = Color.red;

            }
            else
            {
                hearts[i].color = Color.black;
            }
            
           
        }
       
        if (playerHealth <= 0)
        {
            Death();
            Time.timeScale = 0;
            
        }
        
    }
    public void Death()
    {
        OnPlayerDeath?.Invoke();
        movement.dead = true;
        
    }

    
                             
}

