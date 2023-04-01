using StrongPrimitives.Base;

namespace Test.Base;

public class PositiveIntTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        var negativeValue = -1;
        Assert.Throws<ArgumentException>(() => PositiveInt.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        var zeroValue = 0;
        Assert.Throws<ArgumentException>(() => PositiveInt.From(zeroValue));
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        var positiveValue = 1;

        var positive = PositiveInt.From(positiveValue);

        Assert.Equal(positiveValue, positive.Value);
    }
}