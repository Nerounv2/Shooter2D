using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidbody;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 3f;
    [SerializeField] private GameObject playerPrefab;

    private Vector2 moveVector;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();

    }


    private void Update()
    {

        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(new Vector2(0, jumpForce * 5f), ForceMode2D.Impulse);
        }
    }

    private void Move()
    {
        moveVector.x = Input.GetAxis("Horizontal");


        playerRigidbody.velocity = new Vector2(moveVector.x * moveSpeed, playerRigidbody.velocity.y);


       
    }
}
