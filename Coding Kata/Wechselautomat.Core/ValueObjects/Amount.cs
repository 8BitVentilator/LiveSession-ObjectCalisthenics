namespace Wechselautomat.Core.ValueObjects;

public record Amount : IComparable<Amount>
{
    public decimal Value { get; }

    public Amount(decimal Value)
    {
        if (Value < 0)
            throw new ArgumentOutOfRangeException(nameof(Value), "Value must not be negative.");
        this.Value = Value;
    }

    public static implicit operator Amount(decimal value) => new(value);
    public static implicit operator decimal(Amount amount) => amount.Value;

    public int CompareTo(Amount? other)
        => Value.CompareTo(other?.Value);
}

public record Paying(decimal Value) : Amount(Value);
public record Receiving(decimal Value) : Amount(Value);
