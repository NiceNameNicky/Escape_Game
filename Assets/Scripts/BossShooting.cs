using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletCooldown = 0f;

    private float bulletForce = 1f;


    private void Start()
    {
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
    }
    void Update()
    {
        BulletCooldown();

        if (Input.GetKeyDown("space"))
        {
            if (bulletCooldown <= 0f)
            {
                Shoot();
            } else
            {
                Debug.Log("Fireball is still in Cooldown: " + Mathf.Round(bulletCooldown * 10.0f) * 0.1f + "s");
            }
        }
        
    }

    void BulletCooldown()
    {  
        if(bulletCooldown > 0)
        {
            bulletCooldown -= 1f * Time.deltaTime;
        } else
        {
            bulletCooldown = 0;
        }
    }

    void Shoot()
    {
        bulletCooldown = 2f;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
        }
    }
}
