using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{

    void Start()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Human")
        {
            collision.gameObject.SendMessage("ApplyDamage");
            SelfDestruct();
        } 
        else if (collision.gameObject.tag == "Obstacle")
        {
            SelfDestruct();
        }
    }

    public void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
