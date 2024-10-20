using System.Collections;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }
    void OnTriggerEnter(Collider collision)
    {
       
       
        collision.gameObject.GetComponent<MovementController>().scoreSum();
       
        gameObject.gameObject.SetActive(false);
    }
   
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10 * Time.deltaTime, 0, 0);
    }
}
