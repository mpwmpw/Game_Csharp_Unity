using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGRockMove : MonoBehaviour
{
    //����һ���ƶ��ٶ�
    Vector2 speed =  new Vector2 (-0.25f, 0);
    //����һ�����ٶ�  
    //private int angularSpeed = 10;
    // Use this for initialization
    void FixedUpdate()
    {
        //������������һ���ƶ��ٶȣ�transform.forward���������ǰ�����ƶ���
        GetComponent<Rigidbody2D>().velocity = speed;
        // ������������һ�����ٶ� 
        //GetComponent<Rigidbody2D>().angularVelocity = transform.up * angularSpeed;
    }
}
