using StrongPrimitives.Base;

namespace Test.Base;

public class PositiveFloatTests
{
    [Fact]
    public void NegativeValue_ThrowsArgumentException()
    {
        float negativeValue = -1;
        Assert.Throws<ArgumentException>(() => PositiveFloat.From(negativeValue));
    }

    [Fact]
    public void ZeroValue_Ok()
    {
        float zeroValue = 0;
        Assert.Throws<ArgumentException>(() => PositiveFloat.From(zeroValue));
    }

    [Fact]
    public void PositiveValue_Ok()
    {
        float positiveValue = 1;

        var positive = PositiveFloat.From(positiveValue);

        Assert.Equal(positiveValue, positive.Value);
    }
}