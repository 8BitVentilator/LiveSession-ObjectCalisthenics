using Wechselautomat.Core.ValueObjects;

namespace Wechselautomat.Core;

public class ChangeRenderer
{
    public static IEnumerable<string> Render(IEnumerable<Change> changes)
        => changes
            .OrderBy(change => change.Cash.Amount)
            .Select(change => $"{change.Quantity} x {Value(change.Cash)} {CashType(change)}");

    private static string CashType(Change change)
        => (change.Quantity, change.Cash) switch
        {
            (1, Coin) => "Münze",
            ( > 1, Coin) => "Münzen",
            (1, Note) => "Schein",
            ( > 1, Note) => "Scheine",
            _ => throw new NotSupportedException()
        };

    private static string Value(Cash cash)
        => cash.Amount < 1m
            ? $"{(int)(cash.Amount * 100)} Cent"
            : $"{(int)(cash.Amount)} Euro";
}
