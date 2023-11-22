using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // I will write private components without "SerializeField"
    // just like public ones, without this "_" symbol
    [Header("Component References")]
    public Rigidbody2D playerRigidbody;

    [Header("Movement Settings")]
    public float movementSpeed = 3f;

    private Vector2 _movementDirection;

    public void UpdateMovementData(Vector2 newMovementDirection)
    {
        _movementDirection = newMovementDirection;
    }

    private void FixedUpdate()
    {
        MoveThePlayer();
    }


    //I am using Velocity instead of MovePosition cause I need more raw movement here
    private void MoveThePlayer()
    {
        Vector2 movement = movementSpeed * _movementDirection;
        playerRigidbody.velocity = movement;
    }
}
