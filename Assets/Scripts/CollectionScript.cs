using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionScript: MonoBehaviour
{

    public Text pointAmount;
    public Text winText;
    public int collectAmount;
    // Use this for initialization
    void Start()
    {
        pointAmount.text = "Collected: " + collectAmount;
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        pointAmount.text = "Collected: " + collectAmount;

        if (collectAmount == 6)
        { 
            pointAmount.text = "";
            winText.text = "You did the things, I like the way you think.";
        }
    }
}
