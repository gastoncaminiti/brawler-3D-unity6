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
        Vector3 direccion = CalcularMovimiento();
        
        maquinaEstado.Animador.SetFloat("Vert",  direccion.magnitude);
        
        if(direccion.magnitude == 0) return;
      
        maquinaEstado.Controller.Move(direccion * maquinaEstado.VelocidadMovimiento * deltaTime);
        MirarDireccion(direccion, deltaTime);

    }

    public override void Finalizar()
    {
        Debug.Log("FINALIZAR MOVIMIENTO");
    }
    
    private Vector3 CalcularMovimiento()
    {
        Vector3 forward = maquinaEstado.CamaraTransform.forward;
        Vector3 right   = maquinaEstado.CamaraTransform.right;

        forward.y = 0f;
        right.y = 0f;
        
        Vector2 input = maquinaEstado.ObtenerInputMovimiento();
        
        return forward.normalized * input.y + right.normalized * input.x;
    }

    private void MirarDireccion(Vector3 direccion, float deltaTime)
    {
        maquinaEstado.transform.rotation = Quaternion.Lerp(
                                            maquinaEstado.transform.rotation,
                                            Quaternion.LookRotation(direccion),
                                            deltaTime * 6f);
    }
}
