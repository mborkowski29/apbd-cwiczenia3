namespace cwiczenia3.Containers;

public static class GeneratorContainer
{
    private static Dictionary<string, int> containerCount = new Dictionary<string, int>();

    public static string GenerowanieNumeruSeryjnego(string typKontenera)
    {
        if (!containerCount.ContainsKey(typKontenera))
        {
            containerCount[typKontenera] = 1;
        }
        else
        {
            containerCount[typKontenera]++;
        }

        return $"KON-{typKontenera}-{containerCount[typKontenera]}";
    }
}
