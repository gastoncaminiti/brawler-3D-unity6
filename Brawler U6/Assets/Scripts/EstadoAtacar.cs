using UnityEngine;
public class EstadoAtacar : Estado
{
    private const string triggerName = "Ataque1";
    
    public EstadoAtacar(MaquinaEstado maquinaEstado) : base(maquinaEstado)
    {
    }

    public override void Iniciar()
    {
        maquinaEstado.Animador.SetTrigger(triggerName); 
    }
    
    public override void Actualizar(float deltaTime)
    {
        var estadoActual = maquinaEstado.Animador.GetCurrentAnimatorStateInfo(0); // layer 0

        if (estadoActual.normalizedTime >= 1f)
        {
            maquinaEstado.CambiarEstado(new MoverEstado(maquinaEstado));
        }
    }

    public override void Finalizar()
    {
        Debug.Log("SALIR DE ESTADO");
    }
}
