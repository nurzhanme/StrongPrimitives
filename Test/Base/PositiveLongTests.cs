using StrongPrimitives.Base;

namespace Test.Base;

public class PositiveLongTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        long negativeValue = -1;
        Assert.Throws<ArgumentException>(() => PositiveLong.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        long zeroValue = 0;
        Assert.Throws<ArgumentException>(() => PositiveLong.From(zeroValue));
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        long positiveValue = 1;

        var positive = PositiveLong.From(positiveValue);

        Assert.Equal(positiveValue, positive.Value);
    }
}