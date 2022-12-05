using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{


    public float rotatingSpeed = 20;
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotatingSpeed) * Time.deltaTime);
    }
}

