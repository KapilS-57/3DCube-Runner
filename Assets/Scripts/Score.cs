using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text _scoreText;
    int _myScore = 0;
    public Text _finalScoreText;
    
    // Update is called once per frame
    void Update()
    {
        _scoreText.text = _myScore.ToString();
        _finalScoreText.text = "Score : "+_myScore.ToString();
    }

    public void AddScore(int score)
    {
        _myScore += score;
    }
}
