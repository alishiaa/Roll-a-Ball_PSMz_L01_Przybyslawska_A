using UnityEngine;
using UnityEngine.UI;

public class ScoreTextHandler : MonoBehaviour
{
    public Text scoreText;
    public GameManager gameManager; 

    void Start()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: 0";
        }

        
        gameManager = Object.FindFirstObjectByType<GameManager>();

        
        if (gameManager != null)
        {
            gameManager.pickupEvent += UpdateScoreText;
        }
    }


    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + gameManager.all;
        }
    }

    void OnDestroy()
    {
        if (gameManager != null)
        {
            gameManager.pickupEvent -= UpdateScoreText;
        }
    }
}
