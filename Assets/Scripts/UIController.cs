using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text pointAmount;
    public int collectAmount;
	// Use this for initialization
	void Start ()
    {
        pointAmount.text = "Collected: " + collectAmount;
	}
	
	// Update is called once per frame
	void Update ()
    {
        pointAmount.text = "Collected: " + collectAmount;
    }
}
