using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static event Action OnMouseClick;

    [Header("Sub scripts")]
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerAnimations playerAnimations;

    [Header("Player settings")]
    //[SerializeField] private float _smoothSpeed = 1f;
    [SerializeField] private PlayerInput playerInput;

    private Vector2 _rawInputMovement;
    //private Vector2 _smoothInputMovement;

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 inputMovement = value.ReadValue<Vector2>();
        _rawInputMovement = new Vector2(inputMovement.x, inputMovement.y);
    }

    public void OnTest(InputAction.CallbackContext value)
    {
        if(!value.started)
            return;

        Debug.Log(value.ToString());
    }

    public void OnClick(InputAction.CallbackContext value)
    {
        if(!value.started)
            return;

        OnMouseClick?.Invoke();
    }

    private void Update()
    {
        UpdatePlayerMovement();
        UpdateMovementAnimation();
    }


    private void UpdatePlayerMovement()
    {
        playerMovement.UpdateMovementData(_rawInputMovement);
    }

    private void UpdateMovementAnimation()
    {
        playerAnimations.UpdateMovementAnimation(_rawInputMovement.magnitude);
    }


}
