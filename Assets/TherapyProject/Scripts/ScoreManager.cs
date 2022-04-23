using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ScoreManager : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    int _currentScore;
    public int _maxScore;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<TextMeshProUGUI>();
    }

    public void AddPoint()
    {
        
        _currentScore++;
        scoreText.text = "捕获蝴蝶: "+ _currentScore.ToString();
        if (_currentScore == _maxScore)
        {
            scoreText.text = "胜利！";
        }
    }

   
}
