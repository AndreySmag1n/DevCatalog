using CSharpFunctionalExtensions;

namespace DevCatalog.Domain.ValueObjects;

public sealed record DepartmentName
{
    private DepartmentName(string value)
    {
        Value = value;
    }
    public string Value { get; }

    public Result<DepartmentName> CreateDepartmentName(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length <= 3 || value.Length > 150)
        {
            return Result.Failure<DepartmentName>("Имя задано не верно или полностью отсутствует!");
        }

        return new DepartmentName(value);
    }
}