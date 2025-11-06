using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;

namespace DevCatalog.Domain.ValueObjects;

public sealed record DepartmentIdentifier
{
    private DepartmentIdentifier(string value)
    {
        Value = value;
    }
    public string Value { get; }
    
    private static bool IsLatin(string identifier) => Regex.IsMatch(identifier, @"^[a-zA-Z]+$");

    public Result<DepartmentIdentifier> CreateDepartmentIdentifier(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length <= 3 || value.Length > 150 || IsLatin(value))
        {
            return Result.Failure<DepartmentIdentifier>("Идентификатор задан не верно, или " +
                                                        "не полностью состоит из латинских букв, или " +
                                                        "полностью отсутствует!");
        }

        return new DepartmentIdentifier(value);
    }
}