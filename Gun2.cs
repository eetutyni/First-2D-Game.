using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;

    






    private void Update()
    {

        if (Input.GetKeyDown("e"))
        {
            Shoot();
        }


    }



    private void Shoot()
    {

        Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);

    }



}

