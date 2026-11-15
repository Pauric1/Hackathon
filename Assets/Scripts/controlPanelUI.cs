using UnityEngine;

public class controlPanelUI : MonoBehaviour
{
    //panel that display control panel ui
    public GameObject controlPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //open the control panel panel when player collects it
    public void OpenControlPanel()
    {
        //enable the chili plants panel
        controlPanel.SetActive(true);
        Debug.Log("control panel panel opened");
    }

    //close the control panel panel when player presses continue button
    public void CloseControlPanel()
    {
        //disable the control panel panel
        controlPanel.SetActive(false);
        Debug.Log("control panel panel closed");
    }
}
