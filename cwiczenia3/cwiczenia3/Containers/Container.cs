using cwiczenia3.Exceptions;
using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public abstract class Container : IContainer
{
    private int cargoWeight;

    public int CargoWeight
    {
        get;
        set;
    }

    protected Container(int cargoWeight)
    {
        CargoWeight = cargoWeight;
    }
    
    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(int cargoWeight)
    {
        throw new OverfillException("message");
    }
}