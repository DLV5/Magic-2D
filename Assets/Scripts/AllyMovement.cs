using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class AllyMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private bool _isMoving = false;

    public void MoveTo(Vector2 position)
    {
        StartCoroutine(MoveToPosition(position));
    }

    private IEnumerator MoveToPosition(Vector3 position)
    {
        Vector3 direction = transform.position - position;

        while ((transform.position - position).magnitude > 0.1)
        {
            yield return new WaitForSeconds(0.1f);
            transform.position = Vector2.MoveTowards(transform.position, position, speed);
        }
    }
}
