namespace Compuertas;

public class OrGate: IGate
{
    private List<IInput> Inputs;
    private string Nombre;

    public OrGate(string nombre)
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
        bool reultado = false;
        foreach (IInput input in Inputs)
        {
            reultado = reultado || input.BoolValue();
        }

        return reultado;
    }

}