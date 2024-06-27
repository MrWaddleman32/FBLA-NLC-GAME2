using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static Vector2 movement;

    private PlayerInput playerInput;
    private InputAction moveAction;
    public PlayerController playerController;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions["Move"];

    }

    private void Update()
    {
        if(playerController.canMove)
         movement = moveAction.ReadValue<Vector2>();
  
        
    }

}
