using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishbone : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Score -1");
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
