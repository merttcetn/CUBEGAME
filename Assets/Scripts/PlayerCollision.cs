using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // stop player movement
            movement.enabled = false;

            // game over process
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}