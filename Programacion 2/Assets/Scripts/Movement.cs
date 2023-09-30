using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    bool IsGrounded;
    public float jumpingPower;
    public float fallpower;
    private float horizontal;
    public float speed;


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");


        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            IsGrounded = false;
        }if (Input.GetKeyDown(KeyCode.W) && IsGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            IsGrounded = false;
        }



        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, -fallpower);
        } if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -fallpower);
        }


        if (this.transform.position.y < -3)
        {
            this.transform.position = new Vector2(rb.position.x, -2.750017f); 
        }    
        if (this.transform.position.x <= -8)
        {
            this.transform.position = new Vector2(-8f, rb.position.y); 
        }   
        if (this.transform.position.x >= 8)
        {
            this.transform.position = new Vector2(8f, rb.position.y); 
        } 
        if (this.transform.position.y >= 0.14f)
        {
            rb.velocity = new Vector2(rb.velocity.x, -0.75f); 
        }    
    }
    public void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            IsGrounded = true;
        }
    }
}
