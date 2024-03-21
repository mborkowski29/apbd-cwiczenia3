using cwiczenia3.Exceptions;
using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public abstract class Container
{
public string NumerSeryjny { get; }
public double MasaLadunku { get; private set; }
public double Wysokosc { get; }
public double WlasnaWaga { get; }
public double Glebokosc { get; }
public double MaxLadownosc { get; }

public Container(string typKontenera, double masaLadunku, double wysokosc, double wlasnaWaga, double glebokosc, double maxLadownosc)
{
    NumerSeryjny = GeneratorContainer.GenerowanieNumeruSeryjnego(typKontenera);
    MasaLadunku = masaLadunku;
    Wysokosc = wysokosc;
    WlasnaWaga = wlasnaWaga;
    Glebokosc = glebokosc;
    MaxLadownosc = maxLadownosc;
}
public virtual void LoadCargo(double masaLadunku)
{
    if (!CanLoad(masaLadunku))
        throw new OverfillException("przekracza wage");
    MasaLadunku += masaLadunku;
}
public bool CanLoad(double additionalWeight)
{
    return MasaLadunku + additionalWeight <= MaxLadownosc;
}


public virtual void Puste()
{
    MasaLadunku = 0;
}
}

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message) { }
}
