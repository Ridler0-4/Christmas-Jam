using UnityEngine;
using UnityEngine.InputSystem;
using static Collisiondetection;

public class Movement : MonoBehaviour
{
    //private Playercontrols playercontrols;

    public SpriteRenderer crisscross;
    public SpriteRenderer spriteRenderer;
    public GameObject obeject;
    public GameObject Apple;

    [SerializeField]
    private float speed = 25f;

    [SerializeField]
    public float jumpHeight = 3f;

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
    
    void JumpBoost(float Jumpboost)
    {
        Debug.Log("log");
        UnknownPlayersBody.linearVelocityY = Jumpboost;
    }

    private void OnJump(InputValue value)
    {
        Debug.Log("jump");
        if (UnknownPlayersBody.gravityScale == 1)
        {
            if (UnknownPlayersBody.linearVelocityY < 0.01 && UnknownPlayersBody.linearVelocityY > -0.01)
            {
                UnknownPlayersBody.linearVelocityY = jumpHeight;
            }
        }
        else if (UnknownPlayersBody.gravityScale == -1)
        {
            if (UnknownPlayersBody.linearVelocityY < 0.01 && UnknownPlayersBody.linearVelocityY > -0.01)
            {
                UnknownPlayersBody.linearVelocityY = -jumpHeight;
            }
        }

    }

    void Animation()
    {
        if ( UnknownPlayersBody.linearVelocityY > 0.5)
        {
            spriteRenderer.enabled = false;
            Apple.SetActive(true);
        }
        else if (UnknownPlayersBody.linearVelocityX > 1f)
        {
            spriteRenderer.enabled = false;
            obeject.SetActive(true);
            crisscross.flipX = false;
        }
        else if (UnknownPlayersBody.linearVelocityX < -1f)
        {
            spriteRenderer.enabled = false;
            obeject.SetActive(true);
            crisscross.flipX = true;
        }
        else
        {
            spriteRenderer.enabled = true; 
            obeject.SetActive(false);
            Apple.SetActive(false);
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
    void Update()
    {
        Move();
        Animation();
    }


}
