using UnityEngine;

public class FollowPlayerFirstPerson : MonoBehaviour
{
    // Initialize variables
    public GameObject player;
    private Vector3 offsetFirstPerson = new Vector3(0, 2.1f, 0);

    // Update is called once per frame
    void LateUpdate()
    {
        // Offsets position of the camera and follows player
        transform.position = player.transform.position + offsetFirstPerson;
        // Rotates the camera to follow the player
        transform.rotation = player.transform.rotation;
    }
}
