using UnityEngine;

public class MoverEstado: Estado
{
    public MoverEstado(MaquinaEstado maquinaEstado) : base(maquinaEstado){ }

    public override void Iniciar()
    {
        maquinaEstado.Animador.SetFloat("State", 1);
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
