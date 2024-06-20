using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to Rigibody component with "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float steerForce = 100f;

    // for physics stuff
    void FixedUpdate()
    {
        // going forwards
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))  // steer left
        {
            rb.AddForce(-steerForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))  // steer right
        {
            rb.AddForce(steerForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // game ending process
        if (rb.position.y < 0)
        {
            GameObject.FindObjectOfType<GameManager>().EndGame();
        } 

    }
}
