using System.Collections;

namespace Wechselautomat.Core.ValueObjects;

internal sealed class EuroCashCollection : IEnumerable<Cash>
{
    private static readonly Cash[] _array = new Cash[]
    {
        new Coin(.01m),
        new Coin(.02m),
        new Coin(.05m),
        new Coin(.10m),
        new Coin(.20m),
        new Coin(.50m),
        new Coin(1m),
        new Coin(2m),
        new Note(5m),
        new Note(10m),
        new Note(20m),
        new Note(50m),
        new Note(100m),
        new Note(200m),
    };

    public IEnumerator<Cash> GetEnumerator() => _array.AsEnumerable().GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
