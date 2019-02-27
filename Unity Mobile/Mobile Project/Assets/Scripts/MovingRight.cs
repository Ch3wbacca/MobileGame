using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRight : MonoBehaviour
{
    public float jumpSpeed = 1.0f;
    private bool grounded = false;
    private float moveDir = 30.0f;
    public float moveLeftSpeed = 20.0f;
    void Start()
    {
        Move();
    }
    void Move()
    {
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveLeftSpeed * moveDir;
        GetComponent<Rigidbody2D>().velocity = velocity;

    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
}