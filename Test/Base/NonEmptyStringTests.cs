using StrongPrimitives.Base;

namespace Test.Base;

public class NonEmptyStringTests
{
    [Fact]
    public void NullString_ThrowsArgumentNullException()
    {
        string nullString = null;
        Assert.Throws<ArgumentNullException>(() => NonEmptyString.From(nullString));
    }

    [Fact]
    public void EmptyString_ThrowsArgumentException()
    {
        var emptyString = "";
        Assert.Throws<ArgumentException>(() => NonEmptyString.From(emptyString));
    }

    [Fact]
    public void NonEmptyString_Ok()
    {
        var nonEmptyString = "ok";

        var nes = NonEmptyString.From(nonEmptyString);

        Assert.Equal(nonEmptyString, nes.Value);
    }
}