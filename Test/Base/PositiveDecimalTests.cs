using StrongPrimitives.Base;

namespace Test.Base;

public class PositiveDecimalTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        decimal negativeValue = -1;
        Assert.Throws<ArgumentException>(() => PositiveDecimal.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        decimal zeroValue = 0;
        Assert.Throws<ArgumentException>(() => PositiveDecimal.From(zeroValue));
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        decimal positiveValue = 1;

        var positive = PositiveDecimal.From(positiveValue);

        Assert.Equal(positiveValue, positive.Value);
    }
}