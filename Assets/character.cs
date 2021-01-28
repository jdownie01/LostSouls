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
     
    void Start () {
        pos = transform.position;          // Take the initial position
        
    }
 
    void FixedUpdate () {
        if(Input.GetKey(KeyCode.A) && transform.position == pos) {        // Left
            pos += Vector3.left;
        }
        if(Input.GetKey(KeyCode.D) && transform.position == pos) {        // Right
            pos += Vector3.right;
        }
        if(Input.GetKey(KeyCode.W) && transform.position == pos) {        // Up
            pos += Vector3.up;
        }
        if(Input.GetKey(KeyCode.S) && transform.position == pos) {        // Down
            pos += Vector3.down;
        }
        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
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
