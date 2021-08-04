using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerMovement playerMovement;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("Obstacle"))
        {
            playerMovement.enabled = false;
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            FindObjectOfType<GameManager>().EndGame();
        }  
    }

}
