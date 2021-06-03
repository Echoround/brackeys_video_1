
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public Text crashedText;
    public GroundSpawner groundSpawner;

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

        if (collision.collider.tag == "GroundTile")
        {
            Debug.Log(collision.collider.name);
            // groundSpawner.RemoveOldTiles(collision.collider.GetComponent<GameObject>());
            groundSpawner.RemoveOldTiles(collision.collider.GetComponent<Transform>().gameObject);
            groundSpawner.SpawnTile(true);

            
        }


    }

}
