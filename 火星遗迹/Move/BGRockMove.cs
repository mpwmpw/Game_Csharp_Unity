using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGRockMove : MonoBehaviour
{
    //设置一个移动速度
    Vector2 speed =  new Vector2 (-0.25f, 0);
    //设置一个角速度  
    //private int angularSpeed = 10;
    // Use this for initialization
    void FixedUpdate()
    {
        //刚体自身设置一个移动速度，transform.forward代表自身的前方向移动，
        GetComponent<Rigidbody2D>().velocity = speed;
        // 刚体自身设置一个角速度 
        //GetComponent<Rigidbody2D>().angularVelocity = transform.up * angularSpeed;
    }
}
