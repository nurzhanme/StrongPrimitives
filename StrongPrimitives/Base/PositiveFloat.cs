using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class PositiveFloat : ValueOf<float, PositiveFloat>
{
    protected override void Validate()
    {
        Guard.Against.NegativeOrZero(Value, nameof(Value));
    }
}