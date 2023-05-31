using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    Text scoreText;
    int highscore;
    public Text panelScore;
    public Text panelHighScore;

    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        panelScore.text = score.ToString();

        highscore = PlayerPrefs.GetInt("highscore");
        panelHighScore.text = highscore.ToString();
    }
    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
        panelScore.text = score.ToString();

        if(score > highscore)
        {
            highscore = score;
            panelHighScore.text=highscore.ToString();
            PlayerPrefs.SetInt("highscore",highscore);
        }
    }

    void Update()
    {
        
    }
}
