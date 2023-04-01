using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives.Base;

public class NonEmptyString : ValueOf<string, NonEmptyString>
{
    protected override void Validate()
    {
        Guard.Against.NullOrWhiteSpace(Value, nameof(Value));
    }
}