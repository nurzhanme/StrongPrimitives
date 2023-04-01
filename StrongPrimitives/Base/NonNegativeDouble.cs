using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class NonNegativeDouble : ValueOf<double, NonNegativeDouble>
{
    protected override void Validate()
    {
        Guard.Against.Negative(Value, nameof(Value));
    }
}