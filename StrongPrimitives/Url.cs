using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives;

public class Url : ValueOf<string, Url>
{
    protected override void Validate()
    {
        Guard.Against.NullOrWhiteSpace(Value, nameof(Value));

        const int urlMaxLength = 2000;

        // https://stackoverflow.com/questions/417142/what-is-the-maximum-length-of-a-url-in-different-browsers
        if (Value.Length > urlMaxLength)
        {
            throw new ArgumentOutOfRangeException(nameof(Value), $"Max length is {urlMaxLength}");
        }

        if (!Value.StartsWith("http://") && !Value.StartsWith("https://"))
        {
            throw new ArgumentException("Invalid URL", nameof(Value));
        }
    }
}