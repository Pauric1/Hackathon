using UnityEngine;

public class TreadmileUI : MonoBehaviour
{
    //panel that displays the treadmile
    public GameObject treadmilePanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //open the treadmile panel when player collects it
    public void OpenTreadmilePanel()
    {
        //enable the treadmile panel
        treadmilePanel.SetActive(true);
        Debug.Log("Treadmile panel opened");
    }

    //close the treadmile panel when player presses continue button
    public void CloseTreadmilePanel()
    {
        //disable the treadmile panel
        treadmilePanel.SetActive(false);
        Debug.Log("Treadmile panel closed");
    }
}
