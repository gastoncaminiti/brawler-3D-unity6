public abstract class Estado
{
    protected MaquinaEstado maquinaEstado;
    public Estado(MaquinaEstado maquinaEstado)
    {
        this.maquinaEstado = maquinaEstado;
    }
    public abstract void Iniciar();
    public abstract void Actualizar(float deltaTime);
    public abstract void Finalizar();
}