using UnityEngine;

public class EstadoAtacar : Estado
{
    [SerializeField]
    private Animator m_Animator;
    
    
    public EstadoAtacar(MaquinaEstado maquinaEstado) : base(maquinaEstado)
    {
    }

    public override void Iniciar()
    {
        AnimatorStateInfo stateInfo = m_Animator.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName("Atk_K_1") && stateInfo.normalizedTime < 1f)
            return;

        m_Animator.SetTrigger("Atk_K_1"); 
    }
    
    public override void Actualizar(float deltaTime)
    {
        throw new System.NotImplementedException();
    }

    public override void Finalizar()
    {
        throw new System.NotImplementedException();
    }

}
