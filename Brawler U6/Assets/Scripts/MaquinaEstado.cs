using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MaquinaEstado : MonoBehaviour
{
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
}
