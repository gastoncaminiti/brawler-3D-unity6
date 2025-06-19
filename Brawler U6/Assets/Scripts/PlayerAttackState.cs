using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttackState : MonoBehaviour
{
    [SerializeField]
    private Animator m_Animator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnAttackState(InputAction.CallbackContext context)
    {
        
        if (!context.performed) return;

        AnimatorStateInfo stateInfo = m_Animator.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName("Atk_K_1") && stateInfo.normalizedTime < 1f)
            return;

        m_Animator.SetTrigger("Atk_K_1"); 
        
    }
}
