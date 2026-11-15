using UnityEngine;

public class FoodUI : MonoBehaviour
{
    //panel that displays the food
    public GameObject foodPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //open the food panel when player collects it
    public void OpenFoodPanel()
    {
        //enable the food panel
        foodPanel.SetActive(true);
        Debug.Log("Food panel opened");
    }

    //close the food panel when player presses continue button
    public void CloseFoodPanel()
    {
        //disable the food panel
        foodPanel.SetActive(false);
        Debug.Log("Food panel closed");
    }
}