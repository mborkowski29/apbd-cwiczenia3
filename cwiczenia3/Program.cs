// See https://aka.ms/new-console-template for more information
using cwiczenia3.Containers;

/*var container=new Container()
{
    CargoWeight = 100
};*/

/*IEnumerable<int> list =new List<int>();
IEnumerable<int> set =new HashSet<int>();

Dictionary<string, double> dictionary=new();*/

class Program
{
    static void Main(string[] args)
    {
        LiquidContainer container1 = new LiquidContainer(2000, 2500, 10000, 1400, 40000, true);
        container1.LoadCargo(3000);
        GasContainer container2 = new GasContainer(3000, 2800, 10000, 1300, 50000, 10);
        CoolingContainer container3 = new CoolingContainer(4000, 3000, 10000, 1500, 60000, "mięso",-15);

        Console.WriteLine(container1.ToString());
        Console.WriteLine();
        Console.WriteLine(container2.ToString());
        Console.WriteLine();
        Console.WriteLine(container3.ToString());
        
        
        
    }
}
