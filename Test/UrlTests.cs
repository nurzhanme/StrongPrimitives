using StrongPrimitives;
using Xunit;

namespace Test;

public class UrlTests
{
    [Fact]
    public void NullString_ThrowsArgumentNullException()
    {
        string nullString = null;
        Assert.Throws<ArgumentNullException>(() => Url.From(nullString));
    }

    [Fact]
    public void EmptyString_ThrowsArgumentException()
    {
        var emptyString = "";
        Assert.Throws<ArgumentException>(() => Url.From(emptyString));
    }

    [Fact]
    public void NonEmptyNonValidUrlString_Ok()
    {
        var invalidUrlString = "ok";

        Assert.Throws<ArgumentException>(() => Url.From(invalidUrlString));
    }

    [Fact]
    public void InvalidUrlStartsWithHtp_ThrowsArgumentException()
    {
        var invalidUrlString = "htp://example.com";

        Assert.Throws<ArgumentException>(() => Url.From(invalidUrlString));
    }

    [Fact]
    public void ValidUrlStartsWithHttp_Ok()
    {
        var validUrlString = "http://example.com";

        var email = Url.From(validUrlString);

        Assert.Equal(validUrlString, email.Value);
    }

    [Fact]
    public void ValidUrlStartsWithHttps_Ok()
    {
        var validUrlString = "https://example.com";

        var email = Url.From(validUrlString);

        Assert.Equal(validUrlString, email.Value);
    }
}