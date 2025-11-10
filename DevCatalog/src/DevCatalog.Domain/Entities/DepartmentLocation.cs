namespace DevCatalog.Domain.Entities;

public class DepartmentLocation
{
    public int DepartmentId { get; private set; }
    public int LocationId { get; private set; }
    
    public Department Department { get; private set; }
    public Location Location { get; private set; }
}