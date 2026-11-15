using UnityEngine;

public class InteractWithMoonRover : MonoBehaviour, Iinteractable
{
    public SpriteRenderer sr;

    //public reference to the rover ui script
    public MoonRoverUI moonRoverUI;

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
        sr.sortingOrder = 50;
        Debug.Log("Player entered");
    }

    void Function()
    {
        //Destroy(gameObject); //change for it to pop up text panel
        moonRoverUI.OpenMoonRoverPanel();
        //Debug.Log("moon rover panel opened");
    }
} //add to objecets
