using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    HealthController healthController;
    public GameObject GameOverMenu;
    timer timer;


    private void OnEnable()
    {
        HealthController.OnPlayerDeath += EnableGameOverMenu;
        
    }

    private void OnDisable()
    {
        HealthController.OnPlayerDeath -= EnableGameOverMenu;

    }
    public void EnableGameOverMenu()
    {
        
        GameOverMenu.SetActive(true);
       
    }
   public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        movement.dead = false;
    }
}
