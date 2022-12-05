using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    [SerializeField] Text countDown;
    float currentTime = 0f;
    [SerializeField] HealthController _healthController;
    gameover gameover1;
   
    
    float startingTime = 90f;
    void Start()
    {
        currentTime = startingTime;
        
        
    }

   

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDown.text = currentTime.ToString();

        if(currentTime <= 0)
        {
            currentTime = 0;
            _healthController.Death();
            countDown.enabled = false;
            
            
        }
    }
}
