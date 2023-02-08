using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    //Talk to the Key object
    public Key collect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //find out if the key has been collected yet or not
        int LockStatus = collect.KeyStatus();

        //If the key has been picked up, then unlock the door
        if(LockStatus == 1)
        {
            Destroy(this.gameObject);
        }
    }
}
