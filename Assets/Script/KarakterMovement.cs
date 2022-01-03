using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KarakterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    private float dirX = 0f;
    [SerializeField]private float movespeed = 7f;
    [SerializeField]private float jumpForce = 14f;
    //
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f,rb.velocity.y);

        if (Input.Get("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 14f);
        }

        UpdateAnimationState();

    }

    private void UpdateAnimationState()
    {
        if (dirX > of)
        {
            anim.SetBool("running", true);
            sprite.flipx = false;
        }
        else if (dirX < 0f) {
        anim.SetBool("running", true);
        sprite.flipx = false;
    }
    else
    {
        anim.SetBool("running", false);
    }
}
}
