using CSharpFunctionalExtensions;
using DevCatalog.Domain.ValueObjects;

namespace DevCatalog.Domain.Entities;

public class Position
{
    private List<DepartmentPosition> _departmentPositions = [];
    private Position(
        PositionName name, 
        PositionDescription description, 
        IEnumerable<DepartmentPosition> departmentPositions)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        _departmentPositions = departmentPositions.ToList();
    }
    
    public Guid Id { get; private set; }
    
    public PositionName Name { get; private set; }
    
    public PositionDescription Description { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }
    public IReadOnlyCollection<DepartmentPosition> DepartmentPositions => _departmentPositions;

    public static Result<Position> CreatePosition(
        PositionName name, 
        PositionDescription description, 
        IEnumerable<DepartmentPosition> departmentPositions)
    {
        return new Position(name, description, departmentPositions);
    }
}