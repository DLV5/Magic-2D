using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void UpdateMovementAnimation(float speed)
    {
        animator.SetFloat("MovementSpeed", speed);
    }
}
