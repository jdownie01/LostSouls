using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class character : MonoBehaviour
{
    private int health;
    private inventory inventory;
    Vector3 pos;                                // For movement
    float speed = 5.0f;                         // Speed of movement
     
    //Movement
    public float jump;
    float moveVelocity;

    //Grounded Vars
    bool isGrounded = true;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D> ();
    }

    void Update () 
    {
        //Jumping
        if (Input.GetKey (KeyCode.Space) || Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.Z) || Input.GetKey (KeyCode.W)) 
        {   
            if(isGrounded)
            {
                _rigidbody2D.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
                isGrounded = false;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            moveVelocity = speed;
        }

        _rigidbody2D.velocity = new Vector2 (moveVelocity, _rigidbody2D.velocity.y);

    }
    //Check if Grounded
    private void OnTriggerEnter2D(Collider2D other)
    {
        isGrounded = true;
    }
    

    public item getEquipped(int slot)
    {
        switch (slot)
        {
            case 0:
                return inventory.getHead();
            case 1:
                return inventory.getChest();
            case 2:
                return inventory.getFeet();
            case 3:
                return inventory.getWeilded();
        }
        //Exception: Out of bounds. 
        throw new Exception();
    }
}
