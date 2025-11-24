using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;

namespace DevCatalog.Domain.ValueObjects;

public sealed record DepartmentPath
{
    private DepartmentPath(string value)
    {
        Value = value;
    }
    public string Value { get; }
    
    private static bool IsValidPath(string path) => Regex.IsMatch(path, @"^([\w\-]+/)*[\w\-]+$");

    public Result<DepartmentPath> CreateDepartmentPath(string value)
    {
        if (IsValidPath(value))
        {
            return Result.Failure<DepartmentPath>("Этот путь денормализованный!");
        }

        return new DepartmentPath(value);
    }
}