using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    public Rigidbody playerBody;

    public float forwardSpeed = -2000f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerBody.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        if (playerBody.position.z < -1f)
        {
            Destroy(gameObject);
        }
    }
}
