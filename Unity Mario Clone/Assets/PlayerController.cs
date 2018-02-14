using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 15;
    public float jumpPower = 15;

    private Rigidbody2D rb;

    private SpriteRenderer sprRenderer;
    private bool facingRight = true;

    // Use this for initialization
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        sprRenderer = GetComponentInChildren<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");


        rb.velocity = new Vector2(hInput * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpPower * 10);

        }


        if (hInput < 0 && facingRight == true)
            CheckRotation();
        else if(hInput > 0 && facingRight == false)
            CheckRotation();
    }

    private void CheckRotation()
    {
        if (facingRight)
        {
            sprRenderer.flipX = true;
            facingRight = false;
        }
        else
        {

            sprRenderer.flipX = false;
            facingRight = true;
        }
    }
}
