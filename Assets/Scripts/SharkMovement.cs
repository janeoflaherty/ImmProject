using UnityEngine;

public class SharkMovement : MonoBehaviour
{
    public Transform player;  // Reference to the player's transform
    public float speed = 3f;  // Shark's speed

    void Update()
    {
        if (player != null)
        {
            // Move the shark toward the player
            Vector3 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
    }
}
