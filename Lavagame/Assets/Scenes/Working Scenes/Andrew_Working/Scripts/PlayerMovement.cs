using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    //holds the UI elements for health and stamina
    public Slider pStamina;

    public float playerSpeed = 0.3f;

    // used to control the player
    public Rigidbody2D chacacterController;

    // how fast the player can move in any given direction
    private Vector2 speedX, speedY;

    void Update()
    {
        // updates speed
        speedX = new Vector2(playerSpeed, 0); 
        speedY = new Vector2(0, playerSpeed);

        // moves player bassed on the key down
        if (Input.GetKey("a"))
        {
            chacacterController.GetComponent<Rigidbody2D>().MovePosition(chacacterController.GetComponent<Rigidbody2D>().position - speedX);
        }
        else if (Input.GetKey("d"))
        {
            chacacterController.GetComponent<Rigidbody2D>().MovePosition(chacacterController.GetComponent<Rigidbody2D>().position + speedX);
        }
        else if (Input.GetKey("w"))
        {
            chacacterController.GetComponent<Rigidbody2D>().MovePosition(chacacterController.GetComponent<Rigidbody2D>().position + speedY);
        }
        else if (Input.GetKey("s"))
        {
            chacacterController.GetComponent<Rigidbody2D>().MovePosition(chacacterController.GetComponent<Rigidbody2D>().position - speedY);
        }

        // updates the stamina bar
        pStamina.value = playerSpeed;

    }

    public void TakeDamage(float damage)
    {
        if (playerSpeed > 0.1f)
        {
            playerSpeed -= damage;
        }
        if (playerSpeed < 0.1f)
        {
            playerSpeed = 0.1f;
        }
        if (playerSpeed > 0.3f)
        {
            playerSpeed = 0.3f;
        }
    }
}
