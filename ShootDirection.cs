using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//add to asset menu
[CreateAssetMenu(menuName = "Direction")]

//Hi! I keep track of what direction the player
//is facing when they walk around!
public class ShootDirection : ScriptableObject
{
    //The player starts the game facing left
    int direction = 0;

    //Change back to left
    public void FacingLeft()
    {
        direction = 0;
    }

    //Change back to right
    public void FacingRight()
    {
        direction = 1;
    }
    
    //Wait what direction am I facing?
    public int WhatDirection()
    {
        return direction;
    }
}
