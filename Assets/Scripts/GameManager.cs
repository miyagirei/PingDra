using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int scoremeat;
    private Text ScoreMeat;

    public int scorefish;
    private Text ScoreFish;


    void Start()
    {
        scoremeat = 0;
        ScoreMeat = GameObject.Find("Meat+").GetComponent<Text>();
        SetScoreText(scoremeat);

        
        ScoreFish = GameObject.Find("Fish+").GetComponent<Text>();
        SetScoreText1(scorefish);
    }

    public void RunPause()
    {
        SceneManager.LoadScene("RunScene");
    }


    private void SetScoreText(int score)
    {
        ScoreMeat.text = "×" + score.ToString();

        
    }



    private void SetScoreText1(int Fishscore)
    {
        ScoreFish.text = "×" + Fishscore.ToString();
    }

    public void AddScore(int point)
    {
        scoremeat += point;
        SetScoreText(scoremeat);

        
        
    }

    public void Addfish(int fishpoint)
    {
        scorefish += fishpoint;
        SetScoreText1(scorefish);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
