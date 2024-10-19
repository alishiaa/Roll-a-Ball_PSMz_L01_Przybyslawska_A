using UnityEngine;

public class MovementController : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            m_Rigidbody.AddForce(0,0,1 * m_Thrust);

        }
        if (Input.GetKey("s"))
        {
            m_Rigidbody.AddForce(0,0,-1 * m_Thrust);

        }
        if (Input.GetKey("a"))
        {
            m_Rigidbody.AddForce(-1,0,0 * m_Thrust);

        }
        if (Input.GetKey("d"))
        {
            m_Rigidbody.AddForce(1,0,0 * m_Thrust);

        }
    }
}
