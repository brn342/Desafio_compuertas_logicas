namespace Compuertas;

public class NotGate: IGate
{
    private IInput Input;
    private string Nombre;

    public NotGate(string nombre, IInput input)
    {
        Nombre = nombre;
        Input = input;
    }
    
    public void AddInput(IInput input)
    {
        Input = input;
    }
    
    public bool BoolValue()
    {
        return !Input.BoolValue();
    }

}