using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    //プレイヤーを格納する変数
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPos = player.transform.position;

        //カメラとプレイヤーの位置を調整する
        transform.position = new Vector3(playerPos.x + 2, 0, -10);
    }
}