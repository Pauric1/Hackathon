using System;
using UnityEngine;

public class InteractableManager : MonoBehaviour
{

    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D player)
    {
        Debug.Log("Entered Area");
    }
}
