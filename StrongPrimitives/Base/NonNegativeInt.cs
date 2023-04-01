using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class NonNegativeInt : ValueOf<int, NonNegativeInt>
{
    protected override void Validate()
    {
        Guard.Against.Negative(Value, nameof(Value));
    }
}