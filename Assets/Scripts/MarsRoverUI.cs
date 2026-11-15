using UnityEngine;

public class MarsRoverUI : MonoBehaviour
{
    //panel that display rover panel
    public GameObject marsRoverPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //open the moon rover panel when player collects it
    public void OpenMarsSoilPanel()
    {
        //enable the Moon Rover panel
        marsRoverPanel.SetActive(true);
        Debug.Log("mars Rover panel opened");
    }

    //close the mars Rover panel when player presses continue button
    public void CloseMarsSoilPanel()
    {
        //disable the Moon Rover panel
        marsRoverPanel.SetActive(false);
        Debug.Log("mars Rover panel closed");
    }
}