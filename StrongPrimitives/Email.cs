using Ardalis.GuardClauses;
using ValueOf;

namespace StrongPrimitives;

public class Email : ValueOf<string, Email>
{
    private bool IsValidEmail(string email)
    {
        var trimmedEmail = email.Trim();

        if (trimmedEmail.EndsWith("."))
        {
            return false; // suggested by @TK-421
        }
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == trimmedEmail;
        }
        catch
        {
            return false;
        }
    }

    protected override void Validate()
    {
        Guard.Against.NullOrWhiteSpace(Value, nameof(Value));

        if (!IsValidEmail(Value))
        {
            throw new ArgumentException("Invalid Email", nameof(Value));
        }
    }
}