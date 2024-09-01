using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public static int scoreCount;
    public static int highScoreCount;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetInt("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreCount>highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetInt("HighScore", highScoreCount);
        }
        scoreText.text = "Score : " + Mathf.Round(scoreCount);
        highScoreText.text = "High Score : " + highScoreCount;
    }
}
