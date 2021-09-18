using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int score;
    private Text textScore;
    void Start()
    {
        score = 0;
        textScore = GameObject.Find("Score").GetComponent<Text>();
        SetScoreText(score);
    }

    private void SetScoreText(int score)
    {
        textScore.text = "Score :" + score.ToString();
    }

    public void AddScore(int point)
    {
        score += point;
        SetScoreText(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
