using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;

    private int score = 0;

    public int Score
    {
        get { return score; }
        private set { score = value; }
    }

    void Start()
    {
        Score = 0;
        scoreText.text = "0";
    }

    public void AddScore()
    {
        Score++;
        scoreText.text = Score.ToString();

        if (Score > PlayerPrefs.GetInt("BestScore", 0))
        {
            PlayerPrefs.SetInt("BestScore", Score);
            PlayerPrefs.Save();
        }
    }
}