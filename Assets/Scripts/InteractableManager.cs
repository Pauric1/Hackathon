using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface Iinteractable
{
    void Interact();

    void OnTouchingPlayer();

    void OnNotTouchingPlayer();
}
public class InteractableManager : MonoBehaviour
{
    private Iinteractable currentInteractable;
    void Update()
    {
        if (Keyboard.current.eKey.IsActuated() && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Iinteractable interactable = collision.GetComponent<Iinteractable>();   

        if(interactable != null)
        {
            currentInteractable = interactable;
            currentInteractable.OnTouchingPlayer();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Iinteractable interactable = collision.GetComponent<Iinteractable>();

        if (interactable != null && interactable == currentInteractable)
        {
            
            currentInteractable.OnNotTouchingPlayer();
            currentInteractable = null;
        }
    }

}