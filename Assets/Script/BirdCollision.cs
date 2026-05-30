using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameOverManager gameOverManager;

    private bool isGameOver = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isGameOver) return;

        isGameOver = true;
        gameOverManager.ShowGameOver(scoreManager.Score);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isGameOver) return;

        if (other.CompareTag("Score"))
        {
            scoreManager.AddScore();
        }
    }
}