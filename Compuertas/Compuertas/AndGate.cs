namespace Compuertas;

public class AndGate: IGate
{
    private List<IInput> Inputs;
    private string Nombre;

    public AndGate(string nombre)
    {
        Nombre = nombre;
        Inputs = new List<IInput>();
    }

    public void AddInput(IInput input)
    {
        Inputs.Add(input);
    }

    public bool BoolValue()
    {
        bool reultado = true;
        foreach (IInput input in Inputs)
        {
            reultado = reultado && input.BoolValue();
        }

        return reultado;
    }

}