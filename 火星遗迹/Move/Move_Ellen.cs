using UnityEngine;
public class Move_Ellen : MonoBehaviour
{
    //movement speed in units per second
    private float movementSpeed = 5f;
    //定义sprite数组
    public SpriteRenderer SP;
    public Sprite[] pic;
    //定义时间
    float timenum = 1.2f;

    void Update()
    {
        //get the Input from Horizontal axis
        // 对应键盘上面的左右箭头，当按下左或右箭头时触发,按键A和D亦可
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        //对应键盘上面的上下箭头，当按下上或下箭头时触发,按键W和S亦可
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 1.1f*verticalInput * movementSpeed * Time.deltaTime, 0);

        //output to log the position change
        //Debug.Log(transform.position);
        timenum -= Time.deltaTime;
        if (timenum >= 0.8)
        {
            GetComponent<SpriteRenderer>().sprite = pic[0];
        }
        else if (timenum <= 0.8 && timenum > 0.4)
        {
            GetComponent<SpriteRenderer>().sprite = pic[1];
        }
        else if (timenum <= 0.4)
        {
            GetComponent<SpriteRenderer>().sprite = pic[2];
        timenum = 1.2f;
        }
    }
}
