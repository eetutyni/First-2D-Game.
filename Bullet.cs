using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
   
   
    Damage1 Damage;
    public float speed = 40f;
    public Rigidbody2D rb;
    HealthController healthController;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damage1 damageh = collision.GetComponent<Damage1>();
        if (damageh != null)
        {
            damageh.Damage();
        }
        Destroy(gameObject);
        
    }

}


    
