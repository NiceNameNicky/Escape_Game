using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    Vector2 movement;

    public bool active = true;

    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //vmovement.y = Input.GetAxisRaw("Vertical");

        if (active == true)
        {
            Movement();
        }
    }

    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void Movement()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(transform.right * -1f * moveSpeed);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(transform.right * 1f * moveSpeed);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(transform.up * 1f * moveSpeed);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(transform.up * -1f * moveSpeed);
        }
    }

    public void Death()
    {
        active = false;
    }
}
