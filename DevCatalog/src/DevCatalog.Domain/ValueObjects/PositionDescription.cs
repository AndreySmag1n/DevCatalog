using CSharpFunctionalExtensions;

namespace DevCatalog.Domain.ValueObjects;

public sealed record PositionDescription
{
    private PositionDescription(string value)
    {
        Value = value;
    }
    public string Value { get; }

    public Result<PositionDescription> CreatePositionDescription(string value)
    {
        if (value.Length > 1000)
        {
            return Result.Failure<PositionDescription>("Описание слишком длинное!");
        }

        return new PositionDescription(value);
    }
}