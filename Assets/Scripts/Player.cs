using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 15.0f; //プレイヤーの速度
    public float playerJump = 15.0f;


    Rigidbody2D rb; //Rigidbody2Dの変数

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //変数rbにRigidbodyを入れる
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && rb.velocity.y == 0) //もしクリックもしくはタッチされたとき、なおかつ上方向に速度がかかってない時 
        {
            rb.AddForce(transform.up * playerJump);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(playerSpeed, rb.velocity.y); //移動
    }
}
