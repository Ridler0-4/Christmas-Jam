using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisiondetection : MonoBehaviour
{
    bool Detect = false;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {

        if (collider2D.tag == "Player" || collider2D.tag == "Ice Block")
        {
            Debug.Log("Detected!");
            Detect = true;
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
