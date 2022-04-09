using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private float MoveDirection;


    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 3f;
    [SerializeField] private GameObject playerPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();

    }


    private void Update()
    {

        Move();


    }

    private void Move()
    {
        MoveDirection = Input.GetAxis("Horizontal") * moveSpeed;

        playerRigidbody.velocity = new Vector2(MoveDirection, 0);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(new Vector2(0, jumpForce*5f), ForceMode2D.Impulse);
            Debug.Log(jumpForce);
        }
    }
}
