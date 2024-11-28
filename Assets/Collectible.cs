using System.Collections;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public new AudioSource audio;

 
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
 
    void Update()
    {
        transform.Rotate(10 * Time.deltaTime, 0, 0);
    }
}
