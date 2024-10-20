using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody rb;
    public float thrust = 5;
    public int score;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void scoreSum()
    {
        score += 1;
        Debug.Log(score);
        if (score == 7)
        {
            Debug.Log("Wygra³eœ!");
        }
    }
    


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,1 * thrust);

        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-1 * thrust);

        }
        if (Input.GetKey("a"))
        {
           rb.AddForce(-1,0,0 * thrust);

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(1,0,0 * thrust);

        }
    }
}
