using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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

    private void MoveThePlayer()
    {
        Vector2 movement = movementSpeed * Time.deltaTime * _movementDirection;
        playerRigidbody.MovePosition(transform.position + (Vector3)movement);
    }
}
