using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player
    public Vector3 offset = new Vector3(0, 5, -7); // Offset from the player

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
