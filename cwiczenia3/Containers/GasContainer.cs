using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Cisnienie
    {
        get;
    }

    public GasContainer( double wagaLadunku, double wysokosc, double wlasnaWaga, double glebokosc, double maxLadunek, double cisnienie)
        : base("G", wagaLadunku, wysokosc, wlasnaWaga, glebokosc, maxLadunek)
    {
        Cisnienie = cisnienie;
    }

    public override void LoadCargo(double wagaLadunku)
    {
        base.LoadCargo(wagaLadunku);
    }

    public void NotifyHazard(string containerNumber)
    {
        Console.WriteLine($"niebezpieczna sytuacja w kontenerze  {containerNumber}");
    }

    public override void Puste()
    {
        double masa = MasaLadunku;
        base.Puste();
        base.LoadCargo((double)(masa*0.05));
    }
    

    public override string ToString()
    {
        return "Kontener numer: "+NumerSeryjny + "\nMasa ladunku " + MasaLadunku+"kg"
               + "\nGlebokosc "+Glebokosc+"cm"
               +"\nWaga wlasna: "+WlasnaWaga+"kg"+"\nMax ladownosc: "+MasaLadunku+"t"
               +"\nWysokosc: "+Wysokosc+"cm"+"\nCisnienie: "+Cisnienie;
    }
}
