using ObjectCalisthenics.Rule2.Example3.Models;

namespace ObjectCalisthenics.Rule2.Example3.Solution;

// Rule 2: Don’t use the “else” keyword

public class RealWorldProblem
{
    public bool IsFoo(Bar bar, Baz baz) 
        => IsFoo1(bar) || IsFoo2(baz) || IsFoo3(baz);
    
    private static bool IsFoo1(Bar bar) 
        => bar.EnumA != EnumA.A
            && bar.EnumA != EnumA.B
            && bar.EnumA != EnumA.C;
    private static bool IsFoo2(Baz baz)
        => baz == null
            || !baz.Flag1
            || !baz.Flag2
            || baz.Value <= 0;

    private static bool IsFoo3(Baz baz)
        => baz.Calculate() > 0;
}
