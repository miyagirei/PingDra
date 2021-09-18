using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishbone : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collider)　//トリガーがついていたら
    {
        Debug.Log("Score -1");
        Destroy(gameObject); //オブジェクトを消す
    }

    void Update()
    {
        
    }
}
