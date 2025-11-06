using CSharpFunctionalExtensions;

namespace DevCatalog.Domain.ValueObjects;

public sealed record LocationTimezone
{
    private LocationTimezone(string value)
    {
        Value = value;
    }
    public string Value { get; }

    private static bool IsValidTimezone(string timeZone) => timeZone.Contains('/');

    public Result<LocationTimezone> CreateLocationTimezone(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return Result.Failure<LocationTimezone>("Код временной зоны полностью отсутствует!");
        }

        if (!IsValidTimezone(value))
        {
            return Result.Failure<LocationTimezone>("Нарушен формат временной зоны!");
        }

        return new LocationTimezone(value);
    }
}