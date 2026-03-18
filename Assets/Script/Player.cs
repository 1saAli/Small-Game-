using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Keyboard input (Arrow keys / W S)
        float directionY = Input.GetAxisRaw("Vertical");

        // Touch input for mobile devices
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // If the touch is in the upper half of the screen → move up
            if (touch.position.y > Screen.height / 2)
            {
                directionY = 1;
            }
            // If the touch is in the lower half → move down
            else
            {
                directionY = -1;
            }
        }

        // Normalize direction so speed stays consistent
        playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        // Apply movement using Rigidbody2D velocity
        rb.linearVelocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}