using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float distancePerSecond = 1.25f;
    public float force = 10f;
    bool OnGround = false;

    //Create Object of type shootdirection so we know which way to fire
    public ShootDirection playerdirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float dx = 0;
        float dy = 0;


        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) //is the a or left arrow key being pressed?
        {
            dx = -distancePerSecond * Time.deltaTime; //move left

            //The player just moved left, so he is facing left currently
            playerdirection.FacingLeft();
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) //is the d or right arrow key being pressed?
        {
            dx = distancePerSecond * Time.deltaTime; //move right

            //The player just moved right, so he is facing right currently
            playerdirection.FacingRight();
        }
        if (Input.GetKey(KeyCode.Space) && OnGround)
        {
            
            //Add positive force along y axis
            rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse); //move up

        }

        rb.position += new Vector2(dx, dy);
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Is what i just touched the ground?
        GameObject g = collision.gameObject;
        if(g.CompareTag("ground"))
        {
            OnGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        //did I just get off of the ground?
        GameObject g = collision.gameObject;
        if (g.CompareTag("ground"))
        {
            OnGround = false;
        }
    }
}