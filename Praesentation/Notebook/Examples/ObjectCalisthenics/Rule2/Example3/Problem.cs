using ObjectCalisthenics.Rule2.Example3.Models;

namespace ObjectCalisthenics.Rule2.Example3.Problem;

// Rule 2: Don’t use the “else” keyword

public class RealWorldProblem
{
    public bool IsFoo(Bar bar, Baz baz)
    {
        bool result = false;

        if(bar.EnumA == EnumA.A
            || bar.EnumA == EnumA.B
            || bar.EnumA == EnumA.C)
        {
            if(baz != null
                && baz.Flag1
                && baz.Flag2
                && baz.Value > 0)
            {
                var calculation = baz.Calculate();
                if(calculation > 0)
                    result = true;
            }
            else
            {
                result = true;
            }
        }
        else
        {
            result = true;
        }

        return result;
    }
}
