using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisiondetection : MonoBehaviour
{
    bool Detect = false;
    [SerializeField]
    int CollisionType = 0;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {

        while (collider2D.tag == "Player" || collider2D.tag == "Ice Block")
        {
            Debug.Log("Detected!");
            Detect = true;
            if (CollisionType == 0)
            {
                //Jump
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
