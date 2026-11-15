using UnityEngine;

public class DoorUI : MonoBehaviour
{

    //panel that displays the door
    public GameObject doorPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //open the door panel when player interacts with it
    public void OpenDoorPanel()
    {
        //enable the door panel
        doorPanel.SetActive(true);
        Debug.Log("Door panel opened");
    }

    //close the door panel when player presses continue button
    public void CloseDoorPanel()
    {
        //disable the door panel
        doorPanel.SetActive(false);
        Debug.Log("Door panel closed");
    }
}