using CSharpFunctionalExtensions;
using DevCatalog.Domain.ValueObjects;

namespace DevCatalog.Domain.Entities;

public class Position
{
    private List<Department> _departments = [];
    private Position(PositionName name, PositionDescription description, IEnumerable<Department> departments)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        _departments = departments.ToList();
    }
    
    public Guid Id { get; private set; }
    
    public PositionName Name { get; private set; }
    
    public PositionDescription Description { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }

    public static Result<Position> CreatePosition(PositionName name, PositionDescription description, IEnumerable<Department> departments)
    {
        return new Position(name, description, departments);
    }
}