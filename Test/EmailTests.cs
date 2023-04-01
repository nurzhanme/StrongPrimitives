using StrongPrimitives;

namespace Test;

public class EmailTests
{
    [Fact]
    public void NullString_ThrowsArgumentNullException()
    {
        string nullString = null;
        Assert.Throws<ArgumentNullException>(() => Email.From(nullString));
    }

    [Fact]
    public void EmptyString_ThrowsArgumentException()
    {
        var emptyString = "";
        Assert.Throws<ArgumentException>(() => Email.From(emptyString));
    }

    [Fact]
    public void NonEmptyNonValidEmailString_Ok()
    {
        var invalidEmailString = "ok";

        Assert.Throws<ArgumentException>(() => Email.From(invalidEmailString));
    }

    [Fact]
    public void ValidEmailString_Ok()
    {
        var validEmailString = "my@example.com";

        var email = Email.From(validEmailString);

        Assert.Equal(validEmailString, email.Value);
    }
}