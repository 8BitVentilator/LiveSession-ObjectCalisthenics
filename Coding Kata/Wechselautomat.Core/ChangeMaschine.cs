using Wechselautomat.Core.ValueObjects;

namespace Wechselautomat.Core;

public class ChangeMaschine
{
    public static IEnumerable<Change> Changes(Paying paying, Receiving receiving)
        => Changes(receiving - paying)
            .Where(change => change.Quantity > 0);

    private static IEnumerable<Change> Changes(Amount toChange) 
        => new EuroCashCollection()
            .OrderByDescending(cash => cash.Amount)
            .Select(cash =>
            {
                var quantity = (uint)(toChange / cash.Amount);
                toChange -= quantity * cash.Amount;

                return new Change(quantity, cash);
            });
}
