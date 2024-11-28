using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{
    private Rigidbody rb;
    public float thrust = 20;
    public int score;
    public Text scoreText;
    public Text wonText;
    public int all = 7;
    public event System.Action<int> OnScoreChanged;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InitUI();
    }

    void Update()
    {
        HandleMovement();
    }

    private void InitUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: 0";
        }
        if (wonText != null)
        {
            wonText.text = "";
        }
    }

    private void HandleMovement()
    {
       
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 1 * thrust);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -1 * thrust);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-1 * thrust, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(1 * thrust, 0, 0);
        }
    }

    public void Score()
    {
        score += 1;
        UpdateScoreUI();

        OnScoreChanged?.Invoke(score);

        if (score == all)
        {
            Win();
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    private void Win()
    {
        thrust = 0;

        if (wonText != null)
        {
            wonText.text = "Wygrałeś!";
        }
        Debug.Log("Wygrałeś");
        Invoke("LoadNextScene", 1.5f); 
    }

    private void LoadNextScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Scene2")
        {
            SceneManager.LoadScene("EndGame");
        }
        else
        {
            SceneManager.LoadScene("Scene2");
        }
    }
}
