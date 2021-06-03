using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;

    public string playerName;
    public float forwardForce = 2000f;
    public float turningForce = 500f;
    public float jumpingForce = 200f;
    public GroundSpawner groundSpawner;

    //private bool up = false;
    private bool left = false;
    private bool right = false;
    private bool jump = false;
    private bool down = false;


    void Start()
    {
        
       
        Debug.Log("variables is called" + playerName);
        
    }

    private void Update()
    {
        //if (Input.GetKey("w"))
        //{
        //    up = true;
        //}

        if (Input.GetKey("s"))
        {
            down = true;
        }

        if (Input.GetKey("a"))
        {
            left = true;
        }

        if (Input.GetKey("d"))
        {
            right = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            jump = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

       
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);


        //if (up)
        //{
        //    rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        //    up = false;
        //}

        if (down)
        {
            rb.AddForce(0, 0, forwardForce * (-1) * Time.deltaTime, ForceMode.VelocityChange);
            down = false;
        }

        if (left)
        {
            rb.AddForce(turningForce * (-1) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            left = false;
        }

        if (right)
        {
            rb.AddForce(turningForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            right = false;
        }

        if (jump)
        {
            for (int i = 0; i < 7; i++)
            {
                groundSpawner.SpawnTile(false);
            }
            rb.AddForce(0, jumpingForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            jump = false;
        }

        if (rb.position.y < (-3f))
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
