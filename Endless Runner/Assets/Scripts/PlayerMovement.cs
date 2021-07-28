using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerBody;

    public float forwardSpeed = 2000f;
    public float sidewaysSpeed = 500f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // FixedUpdate is for pyhsics
    void FixedUpdate()
    {
        playerBody.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            playerBody.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 
        
        if (Input.GetKey("d"))
        {
            playerBody.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (playerBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
