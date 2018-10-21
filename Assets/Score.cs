using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private GameObject scoreText;

    private int score = 0;
    private int point = 0;
	// Use this for initialization
	void Start () {
        this.scoreText = GameObject.Find("Score");
    }
	
	// Update is called once per frame
	void Update () {
        

    }
   
    //スコアにポイントを追加する関数
    public void AddPoint(int point)
    {
        score = score + point;
        //スコアを表示
        this.scoreText.GetComponent<Text>().text = score.ToString();

    }

    void OnCollisionEnter(Collision collision)
    {
        //衝突判定ごとAddPoint関数を処理
        if (collision.gameObject.tag == "SmallStarTag")
        {
            AddPoint(5);
        }
        if (collision.gameObject.tag == "LargeStarTag")
        {
   
            AddPoint(10);
        }
        if (collision.gameObject.tag == "SmallCloudTag")
        {

            AddPoint(20);
        }
        if (collision.gameObject.tag == "LargeCloudTag")
        {

            AddPoint(30);
        }

    }

}
