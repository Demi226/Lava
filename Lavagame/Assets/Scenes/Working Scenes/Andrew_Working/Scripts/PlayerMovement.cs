using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // the weapon the player uses against the ghosts
    public GameObject playerLamp;

    // how long the lamp and boost lasts
    private float lampTime, boostTime;

    //everything the player holds and can use
    public PlayerInventory playerInventory;

    //holds the UI elements for health and stamina
    public Slider pStamina;

    //how fast the player can move
    public float playerSpeed = 0.3f;

    // used to control the player
    public Rigidbody2D chacacterController;

    // how fast the player can move in any given direction
    private Vector2 speedX, speedY;

    void Update()
    {
        // updates speed
        speedX = new Vector2(playerSpeed + boostTime, 0); 
        speedY = new Vector2(0, playerSpeed + boostTime);

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

        // checks if player has food, then consumes it and gives back some stamina
        if (Input.GetKey("q") && playerInventory.hasFood)
        {
            playerInventory.UpdateInventory(1);
            playerSpeed += 0.1f;
        }
        //check for lamp
        if (Input.GetKey("e") && playerInventory.hasWeapon)
        {
            playerInventory.UpdateInventory(2);
            playerLamp.SetActive(true);
            lampTime = 2f;
        }
        // check for boost
        if(Input.GetKey(KeyCode.LeftShift) && playerInventory.hasBoost)
        {
            playerInventory.UpdateInventory(3);
            boostTime = 0.2f;
        }

        // subtracts boost
        if(boostTime > 0f)
        {
            boostTime -= 0.02f * Time.deltaTime;
        }

        // while lamp is up reduce time
        if(lampTime > 0f)
        {
            lampTime -= 0.1f * Time.deltaTime;
        }
        // when lamp reaches 0 disable it
        if(lampTime <= 0f)
        {
            playerLamp.SetActive(false);
        }
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
