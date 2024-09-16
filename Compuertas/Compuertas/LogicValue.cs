namespace Compuertas;

public class LogicValue: IInput
{
    private bool Valor;

    public LogicValue(bool valor)
    {
        Valor = valor;
    }

    public bool BoolValue()
    {
        return Valor;
    }
}