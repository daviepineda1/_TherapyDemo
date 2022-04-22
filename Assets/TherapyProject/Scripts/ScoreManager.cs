using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text scoreText;
    int _currentScore;
    public int _maxScore;


    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    public void AddPoint()
    {
        
        _currentScore++;
        scoreText.text = _currentScore.ToString();
        if (_currentScore == _maxScore)
        {
            scoreText.text = "You Won";
        }
    }

   
}
