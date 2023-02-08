using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 10.0f;
    bool onGround = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump if space key is down and in collision with ground
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(onGround)
            {
                //apply one time upward force
                rb.AddForce(new Vector2(0, jumpForce));
            }
            
        }
    }

    void OnCollsionEnter2D(Collision2D collision)
    {
        //is what I touched the ground?
        GameObject g = collision.gameObject;
        if(g.CompareTag("ground"))
        {
            //now in collison with ground
            onGround = true;
            
        }
    }

    void OnCollsionExit2D(Collision2D collision)
    {
        //is what I just left the ground?
        GameObject g = collision.gameObject;
        if (g.CompareTag("ground"))
        {
            //left ground
            onGround = false;
        }
    }
}
