using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class PositiveDecimal : ValueOf<decimal, PositiveDecimal>
{
    protected override void Validate()
    {
        Guard.Against.NegativeOrZero(Value, nameof(Value));
    }
}