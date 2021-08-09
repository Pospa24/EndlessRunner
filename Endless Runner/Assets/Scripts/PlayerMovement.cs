using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerBody;

    public float forwardSpeed = 2000f;
    public float sidewaysSpeed = 500f;
    
   
    // Update is called once per frame
    // FixedUpdate is for pyhsics
    void FixedUpdate()
    {
        playerBody.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        
        if (Input.touchCount > 0)
        {
   
            if (Input.GetKey("a") || Input.GetTouch(0).position.x < Screen.width / 2)
            {
                playerBody.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("d") || Input.GetTouch(0).position.x > Screen.width / 2)
            {
                playerBody.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if (playerBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
