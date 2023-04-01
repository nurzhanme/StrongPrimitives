using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class PositiveDouble : ValueOf<double, PositiveDouble>
{
    protected override void Validate()
    {
        Guard.Against.NegativeOrZero(Value, nameof(Value));
    }
}