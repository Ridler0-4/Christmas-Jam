using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 50f;
    [SerializeField]
    private float jumpHeight = 50;

    private Vector2 moveDirection = Vector2.zero;

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

    private void Onjump(InputValue value)
    {
        if (value != null)
        {
            jumpHeight = value.Get<float>();
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
        if (Input.GetButtonDown("Jump") && UnknownPlayersBody.linearVelocityY == 0)
        {
            UnknownPlayersBody.linearVelocityY = jumpHeight;
        }
    }

    void Update()
    {
        Move();
        Jump();
    }


}
