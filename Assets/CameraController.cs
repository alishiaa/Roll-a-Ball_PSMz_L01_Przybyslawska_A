using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; 
    public MovementController playerController;  

    void Start()
    {
       
        player.transform.position = transform.position;
        playerController.transform.position = transform.position;
        transform.position = player.transform.position;
    }

    void LateUpdate()
    {
       
        transform.position = player.transform.position + new Vector3(0, 5, -10);
        transform.LookAt(player.transform); 
    }
}
