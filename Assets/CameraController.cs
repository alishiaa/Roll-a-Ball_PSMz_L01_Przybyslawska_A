using UnityEngine;

public class CameraController : MonoBehaviour
{
   
    private Transform player;
    private Vector3 offset;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = player.position - transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.position - offset;
        transform.LookAt(player);
    }
}
