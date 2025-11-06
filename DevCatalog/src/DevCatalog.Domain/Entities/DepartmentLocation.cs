namespace DevCatalog.Domain.Entities;

public class DepartmentLocation
{
    public Guid DepartmentId { get; private set;  }
    public Department Department { get; private set; }
    
    public Guid LocationId { get; private set; }
    public Location Location { get; private set; }
}