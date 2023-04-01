using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class PositiveInt : ValueOf<int, PositiveInt>
{
    protected override void Validate()
    {
        Guard.Against.NegativeOrZero(Value, nameof(Value));
    }
}