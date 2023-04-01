using StrongPrimitives.Base;

namespace Test.Base;

public class NonNegativeLongTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        long negativeValue = -1;
        Assert.Throws<ArgumentException>(() => NonNegativeLong.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        long zeroValue = 0;
        var nonNegative = NonNegativeLong.From(zeroValue);
        Assert.Equal(zeroValue, nonNegative.Value);
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        long positiveValue = 1;

        var nonNegative = NonNegativeLong.From(positiveValue);

        Assert.Equal(positiveValue, nonNegative.Value);
    }
}