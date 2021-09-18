using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meat : MonoBehaviour
{
    public int scorepoint = 10;
    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collider) //トリガーがついていたら
    {
        Destroy(gameObject);　　//オブジェクトを消す
        Debug.Log("Score +1");

        GameObject gm = GameObject.Find("GameManager");
        gm.GetComponent<GameManager>().AddScore(scorepoint);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
