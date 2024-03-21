namespace cwiczenia3.Containers;

public class ShipContainer
{
    public List<Container> Containers { get; private set; }
    public double MaxSzybkosc { get; }
    public int MaxContainers { get; }
    public double MaxWaga { get; }

    public ShipContainer(double maxSzybkosc, int maxContainers, double maxWaga)
    {
        MaxSzybkosc = maxSzybkosc;
        MaxContainers = maxContainers;
        MaxWaga = maxWaga;
        Containers = new List<Container>();
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count < MaxContainers && CalculateTotalWeight() + container.MasaLadunku <= MaxWaga)
        {
            Containers.Add(container);
            Console.WriteLine($"kontener {container.NumerSeryjny} zaladowano na statek");
        }
        else
        {
            Console.WriteLine("nie mozna zaladowac, statek jest pelny");
        }
    }

    public void UnloadContainer(string numerSeryjny)
    {
        Container konDoUsuniecia = Containers.Find(c => c.NumerSeryjny == numerSeryjny);
        if (konDoUsuniecia != null)
        {
            Containers.Remove(konDoUsuniecia);
            Console.WriteLine($"kontener {numerSeryjny} wyladowany ze statku");
        }
        else
        {
            Console.WriteLine($"kontener {numerSeryjny} nie znaleziony na statku");
        }
    }

    public double CalculateTotalWeight()
    {
        double calaWaga = 0;
        foreach (var container in Containers)
        {
            calaWaga += container.MasaLadunku;
        }
        return calaWaga;
    }
}
