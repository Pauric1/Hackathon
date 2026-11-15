using UnityEngine;

public class InteractWithChiliPlants : MonoBehaviour, Iinteractable
{
    public SpriteRenderer sr;

    //public reference to the chili plants ui script
    public chiliPlantsUI chiliPlantsUI;

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
        chiliPlantsUI.OpenChiliPlantsPanel();
        //Debug.Log("Food panel opened");
    }
}
