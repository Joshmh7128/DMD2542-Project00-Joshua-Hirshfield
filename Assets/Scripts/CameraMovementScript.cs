using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour {

    public GameObject Sphere;
    public Vector3    offset;

	// Use this for initialization
	void Start ()
    {
        //calculate the position of the camera relative to the ball, so it moves with it
        offset = transform.position - Sphere.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //set the position of the camera to the same spot, but over near it
        transform.position = Sphere.transform.position + offset;
	}
}
