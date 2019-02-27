using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovementScript : MonoBehaviour
{
    public float JumpPower = 10.0f;
    Rigidbody2D myRidgibody;
    public bool isGrounded = false;

    void Start()
    {
        myRidgibody = transform.GetComponent<Rigidbody2D>();
    }


    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            myRidgibody.AddForce(Vector3.up * (JumpPower * myRidgibody.mass * myRidgibody.gravityScale * 20.0f));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isGrounded = false;
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isGrounded = true;
        }
    }
}
