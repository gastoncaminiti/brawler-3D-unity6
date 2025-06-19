using UnityEngine;
public class EstadoAtacar : Estado
{
    private readonly int ataqueHash = Animator.StringToHash("isAtaque");
    
    public EstadoAtacar(MaquinaEstado maquinaEstado) : base(maquinaEstado)
    {
    }

    public override void Iniciar()
    {
        maquinaEstado.Animador.SetBool(ataqueHash, true); 
    }
    
    public override void Actualizar(float deltaTime)
    {
        var estadoActual = maquinaEstado.Animador.GetCurrentAnimatorStateInfo(0); 

        if (estadoActual.normalizedTime > 0.65f)
        {
            maquinaEstado.CambiarEstado(new MoverEstado(maquinaEstado));
        }
    }

    public override void Finalizar()
    {
        maquinaEstado.Animador.SetBool(ataqueHash, false);
        maquinaEstado.DesbloquearInput();
    }
}
