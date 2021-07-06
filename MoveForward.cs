using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Initialize variables
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Moves object forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
