using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;
using System.Threading.Tasks;
using Unity.VisualScripting;
using System.Threading;

public class Gun : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;

    float timer;
    int waitingTime = 4;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            Shoot();
            timer = 0;
        }
            
       
    }

    private void Shoot()
    {
        
        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        
    }



}
