using UnityEngine;

public class MoverEstado: Estado
{
    public MoverEstado(MaquinaEstado maquinaEstado) : base(maquinaEstado)
    {
    }

    public override void Iniciar()
    {
        Debug.Log("INICIAR ESTADO MOVER");
    }

    public override void Actualizar(float deltaTime)
    {
        Debug.Log("ACTUALIZAR MOVIMIETNO");
    }

    public override void Finalizar()
    {
        Debug.Log("FINALIZAR MOVIMIENTO");
    }
}
