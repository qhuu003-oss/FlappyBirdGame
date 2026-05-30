using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_Text bestScoreText;

    private void Start()
    {
        Time.timeScale = 1f;

        if (bestScoreText != null)
        {
            bestScoreText.text = "Best Score: " + PlayerPrefs.GetInt("BestScore", 0);
        }
        else
        {
            Debug.LogError("Chưa gắn BestScore Text vào MenuManager!");
        }
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}