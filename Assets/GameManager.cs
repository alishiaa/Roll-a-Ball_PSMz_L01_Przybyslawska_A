using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject[] collectibles;
    public int all;
    public event Action pickupEvent;

    void Start()
    {
        collectibles = GameObject.FindGameObjectsWithTag("Collectible");
        all = collectibles.Length;
        Debug.Log("Max score (all): " + all);
    }

    public void CollectScore()
    {
        pickupEvent?.Invoke();  
    }
}
