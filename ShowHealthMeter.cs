using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHealthMeter : MonoBehaviour
{
    Image meter; //Image Component

    //Create Health object so that we can see how he's holding up
    public Health playerHP;
    int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        meter = GetComponent<Image>();

        //Set the health amount of the player
        playerHP.Initalize(health);
    }

    // Update is called once per frame
    void Update()
    {
        //get amount left from scriptable
        int amount = playerHP.CheckHP();

        //use float division to compute percentage of meter to show
        float percentage = amount / 3.0f;

        //Set the fill amount to that percentage
        meter.fillAmount = percentage;
    }
}
