using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    Vector2 movement;

    public bool active = true;

    private void Start()
    {
        
    }

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
        if (Input.GetKey("left"))
        {
            rb.AddForce(transform.right * -1f * moveSpeed);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(transform.right * 1f * moveSpeed);
            
        }
        if (Input.GetKey("up"))
        {
            rb.AddForce(transform.up * 1f * moveSpeed);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(transform.up * -1f * moveSpeed);
        }
    }

    public void Death()
    {
        active = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
        }
    }
}
