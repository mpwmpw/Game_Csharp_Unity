using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGLandMove : MonoBehaviour
{
    //����һ���ƶ��ٶ�
    Vector2 speed = new Vector2(-1.5f, 0);
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
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(3);
    }
}
