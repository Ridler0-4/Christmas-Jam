using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisiondetection : MonoBehaviour
{
    [SerializeField]
    int CollisionType = 0;
    [SerializeField]
    float Jumpboost = 10f;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {

        if (collider2D.tag == "Player" || collider2D.tag == "Ice Block")
        {
            Debug.Log("Detected!");
            if (CollisionType == 0 && collider2D.tag == "Player")
            {
                //Jump
                collider2D.gameObject.SendMessageUpwards("JumpBoost", Jumpboost);
                Debug.Log("Debug");
            }
            else if (CollisionType == 1)
            {
                //Pressure plate
            }
            else if (CollisionType == 2)
            {
                //Spike
            }
        }
  
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<Collider2D>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
