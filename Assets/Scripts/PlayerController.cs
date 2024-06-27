using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    public Vector2 movement;
    public Animator animator;
    public bool canMove;
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    private const string LAST_HORIZONTAL = "LastHorizontal";
    private const string LAST_VERTICAL = "LastVertical";


    private void Start()
    {
        canMove = true;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(canMove);
        if (canMove && !DialogueManager.isActive)
        {
            movement.Set(InputManager.movement.x, InputManager.movement.y);
            animator.SetFloat(HORIZONTAL, movement.x);
            animator.SetFloat(VERTICAL, movement.y);
            rb.velocity = movement * moveSpeed;

            if (movement != Vector2.zero)
            {
                animator.SetFloat(LAST_HORIZONTAL, movement.x);
                animator.SetFloat(LAST_VERTICAL, movement.y);
            }
        }
        else { 
            rb.velocity = Vector2.zero;
            animator.SetFloat(HORIZONTAL, 0);
            animator.SetFloat(VERTICAL, 0);
        }
        
        
    }


    public void stopMoving()
    {
        canMove = false;
    }
    public void startMoving()
    {
        canMove = true;
    }
}
