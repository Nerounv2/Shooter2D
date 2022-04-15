using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript: MonoBehaviour
{
   private Rigidbody2D rb;

    private float speed = 5f;
    private int damage = 20;

    private int life = 0;

    private int lifeMax = 500;

    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        
        if (transform.localScale.x > 0f)
        {
            rb.velocity = transform.right * speed; //Èçìåíåíèå ñêîðîñòè
        }

        if (transform.localScale.x < 0f)
        {
            rb.velocity = (transform.right * -1) * speed; //Èçìåíåíèå ñêîðîñòè
        }

    }

    void Update()
    {
        life++;

        if (life >= lifeMax)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo) //Ìåòîä, êîòîðûé ñðàáàòûâàåò ïðè ïîïàäàíèè
    {
        Destroy(gameObject);
    }

}
