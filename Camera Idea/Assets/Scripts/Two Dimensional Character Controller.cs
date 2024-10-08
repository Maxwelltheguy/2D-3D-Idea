using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDimensionalCharacterController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] int jumpForce = 5;
    [SerializeField] int moveSpeed = 3;
    [SerializeField] int maxSpeed = 5;
    [SerializeField]int leftMaxSpeed = -5;
    int oppositeForce;

    void Start()
    {
        
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,jumpForce,0),ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(moveSpeed * -1,0,0),ForceMode.Acceleration);
        }
        if(rb.velocity.x < leftMaxSpeed)
        {
            oppositeForce = (int)(leftMaxSpeed + rb.velocity.x * -1);
            rb.AddForce(new Vector3(oppositeForce,0,0),ForceMode.Acceleration);
        }
    Debug.Log(rb.velocity.x);  
    }
}
