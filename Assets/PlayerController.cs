using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private float MoveDirection;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 3f;

    

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDirection = Input.GetAxis("Horizontal"); 
        
    }
}
