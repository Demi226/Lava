using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D chacacterController;

    private Vector2 speedX, speedY;

    void Update()
    {
        speedX = new Vector2(0.3f, 0); 
        speedY = new Vector2(0, 0.3f);
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
    }
}
