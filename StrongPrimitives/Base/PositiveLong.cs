using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class PositiveLong : ValueOf<long, PositiveLong>
{
    protected override void Validate()
    {
        Guard.Against.NegativeOrZero(Value, nameof(Value));
    }
}