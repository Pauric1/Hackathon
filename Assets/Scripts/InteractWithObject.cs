using UnityEngine;

public class InteractWithObject : MonoBehaviour, Iinteractable
{
    public SpriteRenderer sr;

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
        Destroy(gameObject);
    }
} //add to objecets
