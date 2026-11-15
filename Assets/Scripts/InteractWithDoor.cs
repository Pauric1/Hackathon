using UnityEngine;

public class InteractWithDoor : MonoBehaviour, Iinteractable
{
    public SpriteRenderer sr;

    //public reference to the door ui script
    public DoorUI doorUI;

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
        doorUI.OpenDoorPanel();
        //Debug.Log("Food panel opened");
    }
}
