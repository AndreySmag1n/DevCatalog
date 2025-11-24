namespace DevCatalog.Domain.Entities;

public class DepartmentLocation
{
    public Guid DepartmentId { get; private set; }
    public Guid LocationId { get; private set; }
    
    public Department Department { get; private set; }
    public Location Location { get; private set; }

    public DepartmentLocation(Department department, Location location)
    {
        DepartmentId = Guid.NewGuid();
        LocationId = Guid.NewGuid();
        Department = department;
        Location = location;
    }
}