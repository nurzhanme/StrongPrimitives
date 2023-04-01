using StrongPrimitives.Base;

namespace Test.Base;

public class NonNegativeDoubleTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        double negativeValue = -1;
        Assert.Throws<ArgumentException>(() => NonNegativeDouble.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        double zeroValue = 0;
        var nonNegative = NonNegativeDouble.From(zeroValue);
        Assert.Equal(zeroValue, nonNegative.Value);
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        double positiveValue = 1;

        var nonNegative = NonNegativeDouble.From(positiveValue);

        Assert.Equal(positiveValue, nonNegative.Value);
    }
}