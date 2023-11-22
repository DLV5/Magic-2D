using UnityEngine;
using UnityEngine.InputSystem;

public class AllyController : MonoBehaviour
{
    [Header("Sub scripts")]
    [SerializeField] private AllyMovement allymovement;

    private void OnEnable()
    {
        PlayerController.OnMouseClick += OnMouseClick;
    }

    private void OnDisable()
    {
        PlayerController.OnMouseClick -= OnMouseClick;
    }

    private void OnMouseClick()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        allymovement.MoveTo(mousePosition);
    }
}
