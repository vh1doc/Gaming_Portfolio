using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Object camera follows (set in inspector)
    public GameObject character;
    Rigidbody2D crb; //the rigidbody of the character


    // Start is called before the first frame update
    void Start()
    {
        crb = character.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //Get (x, y) location of the character
        float x = crb.position.x;
        float y = crb.position.y;

        //Get z coordinate of the camera itself
        float z = transform.position.z;

        //Reset position of camera in 3D to player location and previous z
        transform.position = new Vector3(x, y, z);
    }
}
