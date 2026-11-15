using UnityEngine;

public class InteractWithControlPanel : MonoBehaviour, Iinteractable
{
    public SpriteRenderer sr;

    //public reference to the control ui script
    public controlPanelUI controlPanelUI;


    public void Interact()
    {
        Function();
    }

    public void OnNotTouchingPlayer()
    {
        sr.sortingOrder = -10;
    }

    public void OnTouchingPlayer()
    {
        sr.sortingOrder = 30;
    }

    void Function()
    {
        //Destroy(gameObject); //change for it to pop up text panel
        controlPanelUI.OpenControlPanel();
        //Debug.Log("Food panel opened");
    }
} //add to objecets
