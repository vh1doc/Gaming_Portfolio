using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//add to asset menu
[CreateAssetMenu(menuName = "Health")]

//This object keeps track of the player's health
//so that other parts of the game can interact with it or check on it
public class Health : ScriptableObject
{
    int hpamount;

    //set the amount of health the player has
    public void Initalize(int h)
    {
        hpamount = h;
    }

    //decrement the player's health amount
    public void TakeDamage()
    {
        hpamount--;
    }

    //return the health amount
    public int CheckHP()
    {
        return hpamount;
    }
}
