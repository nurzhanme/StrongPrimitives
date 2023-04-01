using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class NonNegativeLong : ValueOf<long, NonNegativeLong>
{
    protected override void Validate()
    {
        Guard.Against.Negative(Value, nameof(Value));
    }
}