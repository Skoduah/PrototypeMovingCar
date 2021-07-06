using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Private variables
    private float speed = 15.0f;
    private float turnSpeed = 35.0f;
    private float horizontalInput;
    private float forwardInput;
    public string inputID;
    // Public variables
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Update is called once per frame
    void Update()
    {
        // Input for the player control
        horizontalInput = Input.GetAxis("Horizontal" + inputID); 
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // Moves game object forward and back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Moves game object left to right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // Switches Camera of object
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !mainCamera.enabled;
        }
    }
}
