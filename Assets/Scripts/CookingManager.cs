using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CookingManager : MonoBehaviour
{
    //Crim 見てくれてありがとう('')ﾉｼ
    //Crim GameManagerにスクリプト゚って付け足してっていいの？

    //Rei

    public float time;
    public Text InstructText;//指示という意味
    public Text leftTime;



    void Start()
    {
        GameObject gm = GameObject.Find("GOD");
        CUT();
    }


    void SetTimeTo10()
    {
        time = 10;
    }

    void CUT()
    {
        SetTimeTo10();
        InstructText.text = "切ろう！";
        //切る処理
    }

    void BOIL()
    {
        SetTimeTo10();
        InstructText.text = "混ぜよう！";//ここ"煮よう！"にするか迷ってる
        //煮る処理
    }

    void TURN()
    {
        SetTimeTo10();
        InstructText.text = "ひっくり返そう！";//肉を焼いてひっくり返すときもコレにするか、それとも"焼こう！"に変えるかどうか迷てる
        //ひっくり返す処理
        //たとえば卵焼き、たこ焼きなど
    }

    //あとはこのへんにvoidいれて、料理の種類によって組み合わせを変えるメソッドを組み込んだりとか


    void Update()
    {
        time -= Time.deltaTime;
        leftTime.text = "のこり " + (time.ToString("f2") + "秒");

        //10秒ごとにメッセージを変更し、メソッドを実行させるようにする予定
        //今は肉しかないので何かしらの肉料理にする予定(なんかあったっけ)
    }
}

//Crim ねる　おやすみ
