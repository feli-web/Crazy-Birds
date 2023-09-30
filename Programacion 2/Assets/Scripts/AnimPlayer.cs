using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y != 0)
        {
            anim.Play("Player_Jump");
        }
        if (rb.velocity.y == 0 && rb.velocity.x != 0)
        {
            anim.Play("Player_Run");
        }
        if (rb.velocity.x == 0 && rb.velocity.y == 0)
        {
            anim.Play("Player_Stand");
        }
        if (rb.velocity.x < 0 )
        {
            sr.flipX = true;
        }
        if (rb.velocity.x > 0 )
        {
            sr.flipX = false;
        }
         
    }
}
