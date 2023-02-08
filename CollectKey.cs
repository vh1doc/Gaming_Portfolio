using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    //creating Key object of the Key scriptable
    public Key collect; 

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Is the thing we hit the player?
        GameObject g = collision.gameObject;
        if (g.CompareTag("Player"))
        {
            //Record in the object the that key was collected
            collect.PickedUpKey();
            //Destory the Key sprite to make it look like it was picked up
            Destroy(this.gameObject);
        }

    }
}
