using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easyandmedium : MonoBehaviour
{
    public float JumpPower = 10.0f;
    Rigidbody2D myRidgibody;
    public bool isGrounded = false;
    public float jumpSpeed = 1.0f;
    private bool grounded = false;
    private float moveDir = 30.0f;
    public float moveLeftSpeed = 20.0f;
    void Start()
    {
        Move();
        myRidgibody = transform.GetComponent<Rigidbody2D>();
    }
    void Move()
    {
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveLeftSpeed * moveDir;
        GetComponent<Rigidbody2D>().velocity = velocity;

    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    public void Jump()
    {
        if(isGrounded == true)
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
    void Update()
    {
        Move();
    }
}

