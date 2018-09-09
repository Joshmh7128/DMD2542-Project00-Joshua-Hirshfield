using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    public float speed;
    public float jumpAmount = 0;
    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //checks verticle movement to help reset jumps
        Vector3 zSpeed = Vector3.Project(rb.velocity, transform.forward);
        float zSpeedMove = zSpeed.magnitude;

        //Defines the movement by creating a Vector3 of our Horizontal and Verticle 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //This applies the force to our object, allowing us to control it. This only applies the X and Y, not the Z
        rb.AddForce(movement * speed);

        //This is where we check to see if the space bar is being pressed down
        if (Input.GetKeyDown(KeyCode.Space))
            {
            //we then check if we are allowed to jump, then jump
                if (jumpAmount > 0)
                {
                    rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
                    jumpAmount =- 1;
                }
            }


    }

    //this is used to check collisions, here we can define our collisions
    void OnCollisionEnter(Collision col)
    {
        if (jumpAmount < 1)
        { 
            if (col.gameObject.name == "Floor")
            {
                jumpAmount = 1;
            }
        }
    }

}

   