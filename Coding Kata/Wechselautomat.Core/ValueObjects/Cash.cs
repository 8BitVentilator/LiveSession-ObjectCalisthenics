namespace Wechselautomat.Core.ValueObjects;

public abstract record Cash(Amount Amount);
public record Coin(Amount Amount) : Cash(Amount);
public record Note(Amount Amount) : Cash(Amount);