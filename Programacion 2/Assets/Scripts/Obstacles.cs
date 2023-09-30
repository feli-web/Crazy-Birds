using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.position -= new Vector2(speed * Time.deltaTime, 0); 

        if (rb.position.x < -9)
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
