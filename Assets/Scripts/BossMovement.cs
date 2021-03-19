using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float rotationSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    void Update()
    {
        if (Input.GetKey("a"))
        {
            rb.rotation += 100.0f * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            rb.rotation -= 100.0f * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(transform.up * moveSpeed);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(transform.up * moveSpeed * -1);
        }
    }

    void FixedUpdate()
    {
        //rb.rotation = movement.x;
    }
}
