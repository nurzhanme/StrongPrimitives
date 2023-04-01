using StrongPrimitives.Base;

namespace Test.Base;

public class NonNegativeIntTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        var negativeValue = -1;
        Assert.Throws<ArgumentException>(() => NonNegativeInt.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        var zeroValue = 0;
        var nonNegative = NonNegativeInt.From(zeroValue);
        Assert.Equal(zeroValue, nonNegative.Value);
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        var positiveValue = 1;

        var nonNegative = NonNegativeInt.From(positiveValue);

        Assert.Equal(positiveValue, nonNegative.Value);
    }
}