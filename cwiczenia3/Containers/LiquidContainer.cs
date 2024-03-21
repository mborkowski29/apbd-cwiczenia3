using cwiczenia3.Interfaces;

namespace cwiczenia3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool czyNiebezpieczny;

    public LiquidContainer(double masaLadunku, double wysokosc, double wlasnaWaga, double glebokosc, double maxLadunek, bool czyNiebezpieczny)
        : base("L", masaLadunku, wysokosc, wlasnaWaga, glebokosc, maxLadunek)
    {
        this.czyNiebezpieczny = czyNiebezpieczny;
    }

    public override void LoadCargo(double masaLadunku)
    {
        {
            if (czyNiebezpieczny)
            {
                if (WlasnaWaga + masaLadunku <= MaxLadownosc * 0.5)
                {
                    base.LoadCargo(masaLadunku);
                }
                else
                {
                    throw new OverfillException("nie mozna zaladowac");
                }
            }
            else
            {
                if (WlasnaWaga + masaLadunku <= MaxLadownosc * 0.9)
                {
                    base.LoadCargo(masaLadunku);
                }
                else
                {
                    throw new OverfillException("nie mozna zaladowac\"");
                }
            }
        }
        base.LoadCargo(masaLadunku);
    }

    public void NotifyHazard(string containerNumber)
    {
        Console.WriteLine("niebezpieczna sytuacja w kontenerze "+containerNumber);
    }
    
    public override string ToString()
    {
        return "Numer konteneru: "+NumerSeryjny + "\nMasa ladunku " + MasaLadunku+"kg"
               + "\nGlebokosc: "+Glebokosc+"cm"+"\nNiebezpieczny: "+czyNiebezpieczny
               +"\nWaga wlasna: "+WlasnaWaga+"kg"+"\nMax ladownosc: "+MasaLadunku+"t"
               +"\nWysokosc: "+Wysokosc+"cm";
    }
}
