using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5.0f; //プレイヤーの速度
    public float playerJump = 15.0f;
    public float defaultSpeed = 5.0f;
    public float defaultJump = 15.0f;

    public Text textContinue;
    public Image imageContinue;


    Rigidbody2D rb; //Rigidbody2Dの変数

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //変数rbにRigidbodyを入れる

        textContinue.enabled = false;
        imageContinue.enabled = false;

    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && rb.velocity.y == 0) //もしクリックもしくはタッチされたとき、なおかつ上方向に速度がかかってない時 
        {
            rb.AddForce(transform.up * playerJump);
        }
    }

    public void StopButton()
    {
        //playerSpeed = 0;
        //playerJump = 0;
        textContinue.enabled = true;
        imageContinue.enabled = true;

        Time.timeScale = 0f;
    }

    public void Continue()
    {
        //playerSpeed = defaultSpeed;
        //playerJump = defaultJump;
        textContinue.enabled = false;
        imageContinue.enabled = false;

        Time.timeScale = 1f;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(playerSpeed, rb.velocity.y); //移動
    }
}
