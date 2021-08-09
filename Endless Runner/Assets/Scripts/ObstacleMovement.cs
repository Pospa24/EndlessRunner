using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody playerBody;

    public float forwardSpeed = -100f;
    public float speedTimer = 5f;
    public float speedMultiplier = 1.1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        playerBody.AddForce(0, 0, forwardSpeed * Time.deltaTime * speedMultiplier, ForceMode.Acceleration);

        if(Time.timeSinceLevelLoad == 0)
        {
            speedTimer = 5f;
        }

        if (Time.timeSinceLevelLoad >= speedTimer) {    
            speedTimer = Time.timeSinceLevelLoad + speedTimer;
            speedMultiplier += .1f;
        }
        if (playerBody.position.z < -1f)
        {
            Destroy(gameObject);
        }
    }
}
