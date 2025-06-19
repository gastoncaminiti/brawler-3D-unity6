using System;
using UnityEngine;

public abstract class Estado
{
    protected MaquinaEstado maquinaEstado;
    protected Type tipoEstado;
    public Estado(MaquinaEstado maquinaEstado)
    {
        this.maquinaEstado = maquinaEstado;
        this.tipoEstado = this.GetType();
        Debug.Log(this.tipoEstado.Name);
    }
  
    public bool EsEstado<Clase>() where Clase : Estado
    { 
        return tipoEstado ==  typeof(Clase);
    }

    public abstract void Iniciar();
    public abstract void Actualizar(float deltaTime);
    public abstract void Finalizar();
}