namespace DevCatalog.Domain.Entities;

public class DepartmentPosition
{
    public int DepartmentId { get; private set; }
    public int PositionId { get; private set; }
    
    public Department Department { get; private set; }
    public Position Position { get; private set; }
}