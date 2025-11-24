using CSharpFunctionalExtensions;

namespace DevCatalog.Domain.ValueObjects;

public sealed record LocationName
{
    private LocationName(string value)
    {
        Value = value;
    }
    public string Value { get; }

    public Result<LocationName> CreateLocationName(string value)
    {
        if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 120 )
        {
            return Result.Failure<LocationName>("Имя задано не верно или полностью отсутствует!");
        }

        return new LocationName(value);
    }
}