using UnityEngine;
using UnityEngine.SceneManagement;


public class CreditGame : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Collider2D>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Player")
        {
            Debug.Log("Congrats");
            SceneManager.LoadScene("Credits-Alex");
        }
    }
}
