using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
public class Move_Drop : MonoBehaviour
{
    //movement speed in units per second
    private float movementSpeed = 5f;
    //����sprite����
    public SpriteRenderer SP;
    public Sprite[] pic;
    //����ʱ��
    float timenum = 0.8f;

    void Update()
    {
        //get the Input from Horizontal axis
        // ��Ӧ������������Ҽ�ͷ������������Ҽ�ͷʱ����,����A��D���
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        //��Ӧ������������¼�ͷ���������ϻ��¼�ͷʱ����,����W��S���
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        //output to log the position change
        //Debug.Log(transform.position);
        timenum -= Time.deltaTime;
        if(timenum >= 0.4)
        {
            GetComponent<SpriteRenderer>().sprite = pic[0];
        }
        else if (timenum <= 0.4 && timenum > 0)        
        {
            GetComponent<SpriteRenderer>().sprite = pic[1];
        }
        else if(timenum <= 0)
        {
            timenum = 0.8f;
        }
    }
}
