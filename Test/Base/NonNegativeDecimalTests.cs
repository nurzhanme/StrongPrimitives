using StrongPrimitives.Base;

namespace Test.Base;

public class NonNegativeDecimalTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        decimal negativeValue = -1;
        Assert.Throws<ArgumentException>(() => NonNegativeDecimal.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        decimal zeroValue = 0;
        var nonNegative = NonNegativeDecimal.From(zeroValue);
        Assert.Equal(zeroValue, nonNegative.Value);
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        decimal positiveValue = 1;

        var nonNegative = NonNegativeDecimal.From(positiveValue);

        Assert.Equal(positiveValue, nonNegative.Value);
    }
}