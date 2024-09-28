using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Vector3 distance = new Vector3(0f, 0f, 1f);
    public Transform platform;
    public Vector3 currentVelocity;
    private Vector3 start;
    private Vector3 lastPosition; 
    public float speed = 2f;

    void Start()
    {
        start = platform.position;
        lastPosition = start;
    }

    void Update()
    {
        Vector3 newPos = distance * Mathf.Sin(Time.time * speed);
        platform.position = start + newPos;

        currentVelocity = new Vector3(0,0,(platform.position.z - lastPosition.z) / Time.deltaTime);

        lastPosition = platform.position;
    }
}
