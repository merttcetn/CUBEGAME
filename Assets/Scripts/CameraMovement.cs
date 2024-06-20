using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // script to follow the player as camera

    public Transform player;
    public Vector3 cameraOffset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + cameraOffset;
    }
}
