using UnityEngine;

public class MoonRoverUI : MonoBehaviour
{
    //panel that display rover panel
    public GameObject moonRoverPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //open the moon rover panel when player collects it
    public void OpenMoonRoverPanel()
    {
        //enable the Moon Rover panel
        moonRoverPanel.SetActive(true);
        Debug.Log("Moon Rover panel opened");
    }

    //close the Moon Rover panel when player presses continue button
    public void CloseMoonRoverPanel()
    {
        //disable the Moon Rover panel
        moonRoverPanel.SetActive(false);
        Debug.Log("Moon Rover panel closed");
    }
}