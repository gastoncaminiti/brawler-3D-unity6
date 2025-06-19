using UnityEngine;
public class EstadoAtacar : Estado
{
    public EstadoAtacar(MaquinaEstado maquinaEstado) : base(maquinaEstado)
    {
    }

    public override void Iniciar()
    {
        Debug.Log(tipoEstado);
        maquinaEstado.Animador.SetTrigger("Atk_K_1"); 
    }
    
    public override void Actualizar(float deltaTime)
    {
        var estadoActual = maquinaEstado.Animador.GetCurrentAnimatorStateInfo(0); // layer 0

        // Si la animación actual terminó (normalizedTime >= 1)
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
