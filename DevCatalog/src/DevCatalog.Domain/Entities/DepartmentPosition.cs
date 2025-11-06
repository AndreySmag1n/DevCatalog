namespace DevCatalog.Domain.Entities;

public class DepartmentPosition
{
    public Guid DepartmentId { get; private set;  }
    public Department Department { get; private set; }
    
    public Guid PositionId { get; private set; }
    public Position Position { get; private set; }
}