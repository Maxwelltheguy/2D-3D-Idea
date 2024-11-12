using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDimensionalCharacterController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] int jumpForce = 8;
    [SerializeField] int moveSpeed = 5;
    [SerializeField] int runSpeed = 10;
    bool isRunning = false;
    bool isGrounded;

    

    void Update()
    {
        CheckForJump();
        CheckIfGrounded();
        CheckForInput();
        
    }
    

    

    void CheckForInput()
    {
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
    }

    void CheckForJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                if (isRunning == false)
                {
                    rb.velocity = new Vector3(rb.velocity.x, 0, 0);
                    rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                }
                else
                {
                    rb.velocity = new Vector3(rb.velocity.x, 0, 0);
                    rb.AddForce(new Vector3(0, jumpForce + 2, 0), ForceMode.Impulse);
                }

            }
        }
        
    }

    void MoveLeft()
    {
        if (isRunning == false)
        {
            transform.Translate(moveSpeed * -1 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(runSpeed * -1 * Time.deltaTime, 0, 0);
        }
        
    }
    void MoveRight()
    {
        if (isRunning == false)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(runSpeed * Time.deltaTime, 0, 0);
        }
    }
    void CheckIfGrounded()
    {
        if (rb.velocity.y == 0)
        {
            isGrounded = true;
        } 
        else
        {
            isGrounded = false;
        }
    }
}

