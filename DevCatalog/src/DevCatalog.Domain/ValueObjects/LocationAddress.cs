using CSharpFunctionalExtensions;

namespace DevCatalog.Domain.ValueObjects;

public sealed record LocationAddress
{
    private LocationAddress(string value)
    {
        Value = value;
    }
    public string Value { get; }

    public Result<LocationAddress> CreateLocationAddress(string value)
    {
        return new LocationAddress(value);
    }
}