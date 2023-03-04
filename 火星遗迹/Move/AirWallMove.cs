using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirWallMove : MonoBehaviour
{
    Vector2 speed = new Vector2(-1.5f, 0);
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = speed; 
    }
}
