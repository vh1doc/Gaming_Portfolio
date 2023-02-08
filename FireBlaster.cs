using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBlaster : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject projectile;
    public float force = 20;
    public float offset = 2f;

    //Keep track of the direction that the player is facing
    public ShootDirection playerdirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Facing is in connection with the direction object
        int facing = playerdirection.WhatDirection();

        if(Input.GetKeyDown("f"))
        { 
            //right fire
            if (facing == 1)
            {
            //Create projectile at the same position and facing the same direction
            GameObject p = Instantiate(projectile, transform.position + (offset * transform.right), transform.rotation);

            //Apply force along local x axis in direction projectile facing
            Rigidbody2D prb = p.GetComponent<Rigidbody2D>();

            //get velocity of fired object
            Vector2 vel = rb.velocity;
            //Give to projectile as initial velocity
            prb.velocity = vel;


            prb.AddRelativeForce(new Vector2(force, 0), ForceMode2D.Impulse);
            }

            //left fire
            if (facing == 0)
            {
            //Create projectile at the same position and facing the same direction
            GameObject p = Instantiate(projectile, transform.position - (offset * transform.right), transform.rotation);

            //Apply force along local x axis in direction projectile facing
            Rigidbody2D prb = p.GetComponent<Rigidbody2D>();

            //get velocity of fired object
            Vector2 vel = rb.velocity;
            //Give to projectile as initial velocity
            prb.velocity = vel;


            prb.AddRelativeForce(new Vector2(-force, 0), ForceMode2D.Impulse);
            }
        }
    }
}

