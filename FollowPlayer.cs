using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Initialize variables
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5,-8);
    
    // Update is called once per frame
    void LateUpdate()
    {
        // Offsets position of the camera and follows player
        transform.position = player.transform.position + offset;
    }
}
