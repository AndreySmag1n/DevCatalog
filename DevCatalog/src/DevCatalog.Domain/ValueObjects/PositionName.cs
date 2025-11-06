using CSharpFunctionalExtensions;

namespace DevCatalog.Domain.ValueObjects;

public sealed record PositionName
{
    private PositionName(string value)
    {
        Value = value;
    }
    public string Value { get; }

    public Result<PositionName> CreatePositionName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 100 )
        {
            return Result.Failure<PositionName>("Имя задано не верно или полностью отсутствует!");
        }

        return new PositionName(value);
    }
}