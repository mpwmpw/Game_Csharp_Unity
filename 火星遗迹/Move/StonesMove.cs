using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesMove : MonoBehaviour
{
    //����һ���ƶ��ٶ�
    Vector2 speed = new Vector2(-1.5f, 0);
    //����һ�����ٶ�  
    float angularSpeed =10;
    // Use this for initialization
    void FixedUpdate()
    {
        //������������һ���ƶ��ٶȣ�transform.forward���������ǰ�����ƶ���
        GetComponent<Rigidbody2D>().velocity = speed;
        // ������������һ�����ٶ� 
        GetComponent<Rigidbody2D>().angularVelocity = angularSpeed;
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("��ʼ��ײ");
    }
    void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("������ײ");
    }
    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("������ײ");
    }

}
