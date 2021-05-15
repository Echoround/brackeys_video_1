
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public Text crashedText;

    void Start()
    {

        crashedText.enabled = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log(collision.collider.name);

            movement.enabled = false;

            crashedText.enabled = true;

            FindObjectOfType<GameManager>().EndGame();
        }

        
    }

}
