using UnityEngine;

public class PlayerAttackState : MonoBehaviour
{
    [SerializeField]
    private Animator m_Animator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnAttackState()
    {
        
        m_Animator.SetTrigger("Atk_K_1");
    }
}
