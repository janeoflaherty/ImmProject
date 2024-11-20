using UnityEngine;

public class SeaweedMovement : MonoBehaviour
{
    public float movementRange = 0.5f;  // The range of movement
    public float speed = 2f;            // Speed of the movement

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;  // Remember the initial position of the seaweed
    }

    void Update()
    {
        // Move the seaweed up and down or left and right
        float offset = Mathf.Sin(Time.time * speed) * movementRange;
        transform.position = startPosition + new Vector3(0, offset, 0);  // Adjust Y-axis position
    }
}
