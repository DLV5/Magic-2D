using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class AllyMovement : MonoBehaviour
{
    /// <summary>
    /// Defines how fast ally will reach desired position
    /// </summary>
    [SerializeField] private float followSpeed;

    //I will do it later, it is not that important for now (23.11.2023)
    ///// <summary>
    ///// Defines speed for idle state, when ally just wondering around
    ///// </summary>
    //[SerializeField] private float idleSpeed;

    private Vector3 _positionToMove;
    private bool _isMoving = false;



    public void MoveTo(Vector2 position)
    {
        _positionToMove = position;

        _isMoving = true;
    }

    private void Update()
    {
        if (_isMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, _positionToMove, followSpeed * Time.deltaTime);
        }
    }
}
