using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerLives = 3;  // Starting lives

    void Start()
    {
        // Initialization logic (if needed)
    }

    void Update()
    {
        // Additional game logic can go here (e.g., score or timer)
    }

    public void PlayerHit()
    {
        playerLives--;  // Decrease the player's lives

        if (playerLives <= 0)
        {
            Debug.Log("Game Over");
            // Handle game over (e.g., restart the game, show a game over screen)
            // You can add a scene reload or an end game state here
        }
    }
}
