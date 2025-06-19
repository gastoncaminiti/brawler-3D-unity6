using System;
using UnityEngine;

public abstract class Estado
{
    protected MaquinaEstado maquinaEstado;
    public Estado(MaquinaEstado maquinaEstado)
    {
        this.maquinaEstado = maquinaEstado;
    }
    public bool EsEstado<Clase>() where Clase : Estado
    {
        return this is Clase;
    }
    public abstract void Iniciar();
    public abstract void Actualizar(float deltaTime);
    public abstract void Finalizar();
}