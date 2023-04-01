using StrongPrimitives.Base;

namespace Test.Base;

public class PositiveDoubleTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        double negativeValue = -1;
        Assert.Throws<ArgumentException>(() => PositiveDouble.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        double zeroValue = 0;
        Assert.Throws<ArgumentException>(() => PositiveDouble.From(zeroValue));
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        double positiveValue = 1;

        var positive = PositiveDouble.From(positiveValue);

        Assert.Equal(positiveValue, positive.Value);
    }
}