using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    

	// Use this for initialization
	void Start ()
    {
        Renderer rend = GetComponent<Renderer>();

        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.green);

        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            GameObject control = GameObject.Find("UIControl");
            CollectionScript playerScript = control.GetComponent<CollectionScript>();
            playerScript.collectAmount += 1;
            Destroy(gameObject);
        }
    }
}


