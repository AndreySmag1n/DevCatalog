using CSharpFunctionalExtensions;
using DevCatalog.Domain.ValueObjects;

namespace DevCatalog.Domain.Entities;

public class Position
{
    private Position(PositionName name, PositionDescription description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
    }
    
    public Guid Id { get; private set; }
    
    public PositionName Name { get; private set; }
    
    public PositionDescription Description { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }

    public static Result<Position> CreatePosition(PositionName name, PositionDescription description)
    {
        return new Position(name, description);
    }
}