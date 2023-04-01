using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class NonNegativeFloat : ValueOf<float, NonNegativeFloat>
{
    protected override void Validate()
    {
        Guard.Against.Negative(Value, nameof(Value));
    }
}