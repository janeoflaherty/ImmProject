using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;       // Player speed
    public GameManager gameManager;  // Reference to the GameManager

    void Start()
    {
        if (gameManager == null)
        {
            gameManager = FindObjectOfType<GameManager>();  // Find the GameManager if not assigned
        }
    }

    void Update()
    {
        // Get player input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Keep player facing the direction of movement
        if (movement != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 0.1f);
        }
    }

    // Handle collisions with seaweed (on collision)
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Seaweed"))
        {
            Debug.Log("Hit Seaweed! Player dies.");
            gameManager.PlayerHit();  // Notify the GameManager that the player has hit seaweed
        }
    }

    // Handle collisions with seaweed (on trigger)
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Seaweed"))
        {
            Debug.Log("Hit Seaweed! Player dies.");
            gameManager.PlayerHit();  // Notify the GameManager that the player has hit seaweed
        }
    }
}
