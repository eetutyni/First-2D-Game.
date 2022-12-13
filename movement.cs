using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    private PolygonCollider2D coll;
    Rigidbody2D rb;
    public Canvas WinScreen;
    [SerializeField] Text fTime;
    timer timer1;
    

    public float speed = 5.0f;
    public float jumpForce = 2f;
    public Animator animator;


    private float translation;


    [SerializeField] public LayerMask jumpableGround;

    public static bool dead = false;

    // Start is called before the first frame update
    void Start()
    {

        
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
        EnablePlayerMovement();

    }
    private void OnEnable()
    {
        HealthController.OnPlayerDeath += DisablePlayerMovement;
    }

    private void OnDisable()
    {
        HealthController.OnPlayerDeath -= DisablePlayerMovement;
    }

    // Update is called once per frame
    void Update()
    {

        if (dead)
        {
            return; 
        }

        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        animator.SetBool("grounded", IsGrounded());

        translation = Input.GetAxis("Horizontal");



        rb.velocity = new Vector2(translation * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown("a"))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }


        if (Input.GetKeyDown("left"))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKeyDown("right"))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

    }
    bool IsGrounded()
    {

        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);

    }
   
    private void DisablePlayerMovement()
    {
        animator.enabled = false;
        rb.bodyType = RigidbodyType2D.Static;
    }
    private void EnablePlayerMovement()
    {
        animator.enabled = true;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("WIN"))
        {
            WinScreen.gameObject.SetActive(true);
            Time.timeScale = 0;
            

        }
    }


}