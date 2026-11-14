using System;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMangerSpaceShip : MonoBehaviour
{

    public float playerSpeed = 1;
    private Rigidbody2D rb;
    private Vector2 movement;

    private Animator animator;

    private SpriteRenderer playerSR;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        animator = gameObject.GetComponent <Animator>();

        playerSR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movement != Vector2.zero)
        {
            animator.SetBool("Walking", true);

            if (movement.x < 0)
            {
                //Flip the sprite
                playerSR.flipX = true;
                Console.Write("Flipped");
            }

            else
            {
                //reset the sprite
                playerSR.flipX = false;
                Console.Write("Unflipped");
            }
        }

        else
        {
            animator.SetBool("Walking", false);
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * playerSpeed * Time.fixedDeltaTime));
    }

    void OnMove(InputValue movePosition)
    {
        movement = movePosition.Get<Vector2>();
    }

}
