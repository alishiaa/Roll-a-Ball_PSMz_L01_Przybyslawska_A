using System.Collections;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioSource audio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void opoznienie()
    {
        Invoke(nameof(Off), 1.0f);
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
    }
    void Start()
    {
      audio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider collision)
    {
       
       
        collision.gameObject.GetComponent<MovementController>().Score();
        
     audio.Play();

        opoznienie();

    }
   void Off()
    {
        gameObject.SetActive(false);
    }
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10 * Time.deltaTime, 0, 0);
    }
}
