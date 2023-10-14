namespace ObjectCalisthenics.Rule2.Example3.Models;

public record Baz(bool Flag1, bool Flag2, int Value, int Calculation)
{
    public int Calculate() => Calculation;
}