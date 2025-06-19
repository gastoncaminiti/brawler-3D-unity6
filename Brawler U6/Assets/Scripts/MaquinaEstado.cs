using UnityEngine;
using UnityEngine.InputSystem;

public class MaquinaEstado : MonoBehaviour
{
    [field:SerializeField]
    public Animator Animador { get; private set; }
    [field: SerializeField] public CharacterController Controller { get; private set; }
    [field: SerializeField] public float VelocidadMovimiento { get; private set; } = 5f;
    
    private Estado estadoActual;
    private Vector2 inputMovimiento;
    
    private void Update()
    {
        if(estadoActual == null) return;
        
        estadoActual.Actualizar(Time.deltaTime);
    }

    public void CambiarEstado(Estado nuevoEstado)
    {
        estadoActual?.Finalizar();
        estadoActual = nuevoEstado;
        estadoActual.Iniciar();
    }
    
    public Vector2 ObtenerInputMovimiento()
    {
        return inputMovimiento;
    }
    //========= Manejar eventos y cambiar de estado =========
    public void OnAttackState(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        if (estadoActual?.EsEstado<EstadoAtacar>() == true) return;
        
        CambiarEstado(new EstadoAtacar(this));
    }
 
    public void OnMove(InputAction.CallbackContext context)
    {
        inputMovimiento = context.ReadValue<Vector2>();
    }
}
