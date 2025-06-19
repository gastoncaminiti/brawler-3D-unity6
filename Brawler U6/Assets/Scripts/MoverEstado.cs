using UnityEngine;

public class MoverEstado: Estado
{
    private const string triggerName = "Mover";
    public MoverEstado(MaquinaEstado maquinaEstado) : base(maquinaEstado)
    {   
        maquinaEstado.Animador.SetFloat("State", 1);
    }

    public override void Iniciar()
    {
        Debug.Log("INICIAR ESTADO MOVER");
        maquinaEstado.Animador.SetTrigger(triggerName); 
    }

    public override void Actualizar(float deltaTime)
    {
        Vector2 input = maquinaEstado.ObtenerInputMovimiento();
        
        Vector3 direccion = new Vector3(input.x, 0f, input.y);
        maquinaEstado.Animador.SetFloat("Hor", input.x);
        maquinaEstado.Animador.SetFloat("Vert", input.y);
        
        maquinaEstado.Controller.Move(direccion * maquinaEstado.VelocidadMovimiento * deltaTime);

    }

    public override void Finalizar()
    {
        Debug.Log("FINALIZAR MOVIMIENTO");
    }
}
