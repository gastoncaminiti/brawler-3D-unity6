using UnityEngine;
using UnityEngine.InputSystem;

public class MaquinaEstado : MonoBehaviour
{
    [field:SerializeField]
    public Animator Animador { get; private set; }
    
    private Estado estadoActual;

    private void Update()
    {
        if(estadoActual == null) return;
        
        estadoActual.Actualizar(Time.deltaTime);
    }

    private void CambiarEstado(Estado nuevoEstado)
    {
        estadoActual?.Finalizar();
        estadoActual = nuevoEstado;
        estadoActual.Iniciar();
    }
    
    //========= Manejar eventos y cambiar de estado =========
    public void OnAttackState(InputAction.CallbackContext context)
    {
        if (estadoActual?.EsEstado<EstadoAtacar>() == true) return;
        
        CambiarEstado(new EstadoAtacar(this));
    }
}
