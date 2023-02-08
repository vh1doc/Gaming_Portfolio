using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attached to Ammo prefab
public class destroyAmmo : MonoBehaviour
{
    //public GameObject explosionPrefab; //Optional if generate explosion
    public string tagname; // Only things with this tag are destroyed

    //Projectile collided with something
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject g = collision.gameObject;
        

        if (g.CompareTag(tagname))
        {
            Destroy(g); //Destroy immiediately if hit

        }

        //Destroy self when hit anything
        Destroy(this.gameObject);
    }
}
