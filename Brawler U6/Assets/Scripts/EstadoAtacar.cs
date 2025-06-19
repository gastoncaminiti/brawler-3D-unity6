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
        Debug.Log("MIENTRAS SE ATACA");
    }

    public override void Finalizar()
    {
        Debug.Log("AL TERMINAR EL ATAQUE");
    }
}
