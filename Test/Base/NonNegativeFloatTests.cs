using StrongPrimitives.Base;

namespace Test.Base;

public class NonNegativeFloatTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        float negativeValue = -1;
        Assert.Throws<ArgumentException>(() => NonNegativeFloat.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        float zeroValue = 0;
        var nonNegative = NonNegativeFloat.From(zeroValue);
        Assert.Equal(zeroValue, nonNegative.Value);
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        float positiveValue = 1;

        var nonNegative = NonNegativeFloat.From(positiveValue);

        Assert.Equal(positiveValue, nonNegative.Value);
    }
}