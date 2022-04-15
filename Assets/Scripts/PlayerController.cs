using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalyerController : MonoBehaviour
{
    public GameObject Bullet;   
    public GameObject Player;
    public Vector2 moveVector;
    public float JumpForce;
    public Rigidbody2D RigidbodyComponent;
    public Animator AnimController;
    public float Health;

    private float speedX = 2f;
    private bool isGrounded;
    

    private void Start()
    {
        RigidbodyComponent = GetComponent<Rigidbody2D>();
        Health = 100.0f;
    }

    private void Update()
    {
        move();
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            RigidbodyComponent.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        AnimController.SetFloat("IsJumping", RigidbodyComponent.velocity.y*JumpForce);
        if(Input.GetKeyDown(KeyCode.A))
        {
            Player.transform.localScale = new Vector2(0.8f * -1, 0.8f);
            Bullet.transform.localScale = new Vector2(0.8f * -1, 0.8f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Player.transform.localScale = new Vector2(0.8f, 0.8f);
            Bullet.transform.localScale = new Vector2(0.8f, 0.8f);
        }
    }
    private void move()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        RigidbodyComponent.velocity = new Vector2(moveVector.x * speedX, RigidbodyComponent.velocity.y);
        AnimController.SetFloat("IsWalking", RigidbodyComponent.velocity.x);
    }   


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true; 
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}