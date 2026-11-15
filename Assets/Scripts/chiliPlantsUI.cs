using UnityEngine;

public class chiliPlantsUI : MonoBehaviour
{
    //panel that displays the chili plants
    public GameObject chiliPlantsPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //open the chili plants panel when player collects it
    public void OpenChiliPlantsPanel()
    {
        //enable the chili plants panel
        chiliPlantsPanel.SetActive(true);
        Debug.Log("Chili plants panel opened");
    }

    //close the chili plants panel when player presses continue button
    public void CloseChiliPlantsPanel()
    {
        //disable the chili plants panel
        chiliPlantsPanel.SetActive(false);
        Debug.Log("Chili plants panel closed");
    }
}
