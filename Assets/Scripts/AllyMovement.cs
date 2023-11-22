using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class AllyMovement : MonoBehaviour
{
    [SerializeField] private float speed;

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
            transform.position = Vector2.MoveTowards(transform.position, _positionToMove, speed * Time.deltaTime);
        }
    }
}
