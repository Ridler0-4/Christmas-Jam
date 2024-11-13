using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    //private Playercontrols playercontrols;

    [SerializeField]
    private float speed = 25f;
    [SerializeField]
    private float jumpHeight = 15f;

    private Vector2 moveDirection = Vector2.zero;


    [SerializeField]
    private Rigidbody2D UnknownPlayersBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnknownPlayersBody = GetComponent<Rigidbody2D>();
    }
    private void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();
    }

    private void OnJump(InputValue value)
    {
        Debug.Log("jump");
        if (UnknownPlayersBody.linearVelocityY == 0)
        {
            UnknownPlayersBody.linearVelocityY = jumpHeight;
        }

    }
    private void Move()
    {
        UnknownPlayersBody.linearVelocityX = moveDirection.x * speed;
        if (UnknownPlayersBody.linearVelocity.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (UnknownPlayersBody.linearVelocity.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    private void Jump()
    {
        
    }

    void Update()
    {
        Move();
        //Jump();
    }


}
