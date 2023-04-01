using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class NonNegativeDecimal : ValueOf<decimal, NonNegativeDecimal>
{
    protected override void Validate()
    {
        Guard.Against.Negative(Value, nameof(Value));
    }
}