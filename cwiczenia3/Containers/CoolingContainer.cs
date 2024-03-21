namespace cwiczenia3.Containers;

public class CoolingContainer : Container
{
    public string TypProduktu { get; }
    public double OdpowiedniaTemp { get; }

    public CoolingContainer(double masaLadunku, double wysokosc, double wlasnaWaga, double glebokosc, double maxLadunek, string typProduktu, double odpowieniaTemp)
        : base("C", masaLadunku, wysokosc, wlasnaWaga, glebokosc, maxLadunek)
    {
        TypProduktu = typProduktu;
        OdpowiedniaTemp = odpowieniaTemp;
    }
    public override string ToString()
    {
        return "Kontener numer: "+NumerSeryjny + "\nMasa ladunku " + MasaLadunku+"kg"
               + "\nGlebokosc "+Glebokosc+"cm"+"\nTyp produktu: "+TypProduktu+"\nOdpowiednia temperatura: "+OdpowiedniaTemp
               +"\nWaga wlasna: "+WlasnaWaga+"kg"+"\nMax ladownosc: "+MasaLadunku+"t"
               +"\nWysokosc: "+Wysokosc+"cm";
    }
}
