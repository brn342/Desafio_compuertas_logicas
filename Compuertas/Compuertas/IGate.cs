namespace Compuertas;

public interface IGate: IInput
{
    void AddInput(IInput input);
}