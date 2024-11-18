using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gravity : MonoBehaviour
{
    bool swap = false;
    [SerializeField]
    private Rigidbody2D UnknownPlayersBody;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnknownPlayersBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnInteract(InputValue value)
    {
        if (swap == false)
        {
            swap = true;
            this.GetComponent<SpriteRenderer>().flipY = true;
            UnknownPlayersBody.gravityScale = -1;
        }
        else if (swap == true)
         {
            swap = false;
            this.GetComponent <SpriteRenderer>().flipY = false;
            UnknownPlayersBody.gravityScale = 1;
         }

    }
}
