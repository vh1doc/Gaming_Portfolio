using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPace : MonoBehaviour
{
    //Enemy's Rigidbody
    Rigidbody2D erb;
    public float distancePerSecond = 0.75f;
    //distance moved in the walk cycle
    float distanceMoved = 0f;
    float maxDist = 500f;
    
    //Create Health Object so that the enemy can interact with the Player's health
    public Health playerHP;

    //Link to animator controls
    Animator conlink;



    // Start is called before the first frame update
    void Start()
    {
        erb = GetComponent <Rigidbody2D>();
        conlink = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = 0;
        float dy = 0;

        //Let the enemy walk to the right so far and then change direction
        //make him walk back and forth
        if (distanceMoved < maxDist)
        {
            //play the walk east animation
            conlink.SetTrigger("east");

            dx = distancePerSecond * Time.deltaTime; //move right

            distanceMoved++;
        }
        if(distanceMoved >= maxDist)
        {
            //play the walk west animation
            conlink.SetTrigger("west");

            dx = -distancePerSecond * Time.deltaTime; //move left

            distanceMoved++;
        }
        if(distanceMoved == 1000f)
        {
            //Reset the distance moved back to zero to restart cycle
            distanceMoved = 0f;
        }

        erb.position += new Vector2(dx, dy);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //see if what we hit is the player
        GameObject p = collision.gameObject;
        if (p.CompareTag("Player"))
        {
            //if so, hurt the player
            playerHP.TakeDamage();

            //and if the player's health reaches zero,
            //then skip to the game over screen and end game
            if(playerHP.CheckHP() <= 0)
            {
                Destroy(p);
                SceneManager.LoadScene(3);
            }
        }

    }
}
