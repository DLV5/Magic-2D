using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Sub scripts")]
    [SerializeField] private PlayerMovement playerMovement;

    [Header("Player settings")]
    [SerializeField] private float _smoothSpeed = 1f;
    [SerializeField] private PlayerInput _playerInput;

    private Vector2 _rawInputMovement;
    private Vector2 _smoothInputMovement;


    // Update is called once per frame
    //void Update()
    //{
    //    if (_playerMoveActions.IsPressed())
    //    {
    //        OnMove();
    //    }
    //}

    //private void OnDisable()
    //{
    //    _playerMoveActions.Disable();
    //}

    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 inputMovement = value.ReadValue<Vector2>();
        _rawInputMovement = new Vector2(inputMovement.x, inputMovement.y);
    }

    private void Update()
    {
        CalculateMovementInputSmoothing();
        UpdatePlayerMovement();
    }

    private void CalculateMovementInputSmoothing()
    {
        _smoothInputMovement = Vector3.Lerp(_smoothInputMovement, _rawInputMovement, Time.deltaTime * _smoothSpeed);
    }

    private void UpdatePlayerMovement()
    {
        playerMovement.UpdateMovementData(_smoothInputMovement);
    }


}
