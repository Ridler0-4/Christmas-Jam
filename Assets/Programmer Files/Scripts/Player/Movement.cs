using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
    [SerializeField]
    private float jumpHeight = 15;

    private Vector2 moveDirection = Vector2.zero;

    private Rigidbody2D UnknownPlayersBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnknownPlayersBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        if (UnknownPlayersBody.linearVelocity.x > 6)
        {
            UnknownPlayersBody.linearVelocity = new Vector2(UnknownPlayersBody.linearVelocity.x - 4 , UnknownPlayersBody.linearVelocity.y);
            return;
        }
        else if (UnknownPlayersBody.linearVelocity.x < -6)
        {
            UnknownPlayersBody.linearVelocity = new Vector2(UnknownPlayersBody.linearVelocity.x + 4, UnknownPlayersBody.linearVelocity.y);
            return;
        }
        else
        {
            UnknownPlayersBody.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, UnknownPlayersBody.linearVelocity.y);
        }

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
        if (Input.GetButtonDown("Jump") && UnknownPlayersBody.linearVelocity.y == 0)
        {
            {
                UnknownPlayersBody.linearVelocity = new Vector2(UnknownPlayersBody.linearVelocity.x, jumpHeight);
            }
        }
    }





}
