using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDimensionalCharacterController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] int jumpForce = 5;
    [SerializeField] int moveSpeed = 10;
    bool jump;

    

    void Update()
    {
        CheckForInput();
    
    }
    

    void FixedUpdate()
    {
        if (jump == true)
        {
            Jump();
        }

    }

    void CheckForInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            Jump();
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        
    }

    void Jump()
    {
        if (rb.velocity.y == 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, 0);
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
        jump = false;

    }

    void MoveLeft()
    {
        transform.Translate(moveSpeed * -1 * Time.deltaTime, 0, 0);
    }
    void MoveRight()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
    }

}

