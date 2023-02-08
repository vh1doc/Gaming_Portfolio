using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAnimationF : MonoBehaviour
{
    //final project version
    //Link to animation controller
    Animator conlink;
    bool idle = true;

    

    // Start is called before the first frame update
    void Start()
    {
        conlink = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Transition to walking east first frame right arrow down
        if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
             
                //transitioning to the east animation
                conlink.SetTrigger("walkeast");
                idle = false;

        }

        //Transition to walking west first frame left arrow down
        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
                //transitioning to the west animation
                conlink.SetTrigger("walkwest");
                idle = false;

        }

        //Transition to idle animation if we're not doing anything else
        if (idle == false && !Input.anyKey)
        {
            idle = true;
            Debug.Log("We're Idling..");

            //play east facing idle animation
            if (Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.RightArrow))
            {
                conlink.SetTrigger("rightidle");
            }

            //play west facing idle animation
            if (Input.GetKeyUp("a") || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                conlink.SetTrigger("leftidle");
            }
        }


    }

    
}
