using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesMove : MonoBehaviour
{
    //设置一个移动速度
    Vector2 speed = new Vector2(-1.5f, 0);
    //设置一个角速度  
    float angularSpeed =10;
    // Use this for initialization
    void FixedUpdate()
    {
        //刚体自身设置一个移动速度，transform.forward代表自身的前方向移动，
        GetComponent<Rigidbody2D>().velocity = speed;
        // 刚体自身设置一个角速度 
        GetComponent<Rigidbody2D>().angularVelocity = angularSpeed;
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("开始碰撞");
    }
    void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("正在碰撞");
    }
    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("结束碰撞");
    }

}
