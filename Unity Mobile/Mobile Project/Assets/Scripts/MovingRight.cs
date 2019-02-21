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
    
    
    
    public void Jump()
    {
        if (grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(
                new Vector2(0, 100 * jumpSpeed));
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = false;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }
      
}
    
       

