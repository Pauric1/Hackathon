using UnityEngine;

public class InteractWithObject : MonoBehaviour, Iinteractable
{
    public SpriteRenderer sr;

    //public reference to the food ui script
    public FoodUI foodUI;

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
        foodUI.OpenFoodPanel();
        //Debug.Log("Food panel opened");
    }
} //add to objecets
