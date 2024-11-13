using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Movement;
public class Collisiondetection : MonoBehaviour
{
    [SerializeField]
    public int CollisionType = 0;

    [SerializeField]
    float Jumpboost = 10f;



    private void OnTriggerEnter2D(Collider2D collider2D)
    {

        while (collider2D.tag == "Player" || collider2D.tag == "Ice Block")
        {
            Debug.Log("Detected!");
            if (CollisionType == 0)
            {
                //jump
                collider2D.gameObject.GetComponent<Movement>().JumpBoost(Jumpboost);
                Debug.Log("JumpBoost Started");
            }
            else if (CollisionType == 1)
            {
                //pressureplate
            }
            else if (CollisionType == 2)
            {
               //plate
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
