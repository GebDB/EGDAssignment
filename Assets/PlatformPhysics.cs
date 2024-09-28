using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPhysics : MonoBehaviour
{
    public PlatformMovement platformMovement; 
    public Transform player; 

    void Update()
    {

    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.position += platformMovement.currentVelocity * Time.deltaTime;
            Debug.Log("Player Position: " + player.position);
            Debug.Log("Platform Velocity: " + platformMovement.currentVelocity);
        }
    }
}
