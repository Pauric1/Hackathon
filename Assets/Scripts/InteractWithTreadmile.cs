using UnityEngine;

public class InteractWithTreadmile : MonoBehaviour, Iinteractable
{
    public SpriteRenderer sr;

    //public reference to the treadmile ui script
    public TreadmileUI treadmileUI;

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
        treadmileUI.OpenTreadmilePanel();
        //Debug.Log("Food panel opened");
    }
}
