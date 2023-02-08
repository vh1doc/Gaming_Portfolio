using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//add to asset menu
[CreateAssetMenu(menuName = "Key")]

//This object keeps track of whether or not
//the key to the door was picked up or not
public class Key : ScriptableObject
{
    int havekey = 0;

    //Pick up the key
    public void PickedUpKey()
    {
        havekey = 1; 
    }

    //get whether the player has picked up the key or not yet
    public int KeyStatus()
    {
        return havekey;
    }
}
