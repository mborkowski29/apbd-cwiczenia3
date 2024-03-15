﻿namespace cwiczenia3.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(int cargoWeight) : base(cargoWeight)
    {
        
    }
    
    public override void Load(int cargoWeight)
    {
        Console.WriteLine();
        base.Load(cargoWeight);
        //throw new NotImplementedException();
    }
}