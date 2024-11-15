using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{
    private Rigidbody rb;
    public float thrust = 5;
    public int score;
    public Text scoreText;
    public Text wonText;
    public int all = 7;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (scoreText != null)
        {
            scoreText.text = "Score: 0";
        }
        if (wonText != null)
        {
            wonText.text = "";
        }
    }

    void Update()
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
            rb.AddForce(-1, 0, 0 * thrust);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(1, 0, 0 * thrust);
        }
    }

    public void Score()
    {
        score += 1;
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        if (score == all)
        {
            if (wonText != null)
            {
                wonText.text = "Wygra³eœ!";
            }
            Debug.Log("Wygra³eœ!");
        }
    }
}
