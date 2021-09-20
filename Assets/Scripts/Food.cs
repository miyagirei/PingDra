using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int foods = 1;

    public int scorepoint = 0;
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider) //トリガーがついていたら
    {
        GameObject gm = GameObject.Find("GameManager");
        switch (foods)
            {
                case 1:

                        Destroy(gameObject);  //オブジェクトを消す
                        Debug.Log("Score +1");


                        gm.GetComponent<GameManager>().AddScore(scorepoint);

                        break;
                case 2:


                        Debug.Log("Score -1");
                        Destroy(gameObject); //オブジェクトを消す


                        gm.GetComponent<GameManager>().Addfish(scorepoint);

                        break;
            }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
