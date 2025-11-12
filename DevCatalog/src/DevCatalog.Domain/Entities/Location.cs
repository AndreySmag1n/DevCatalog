using CSharpFunctionalExtensions;
using DevCatalog.Domain.ValueObjects;

namespace DevCatalog.Domain.Entities;

public class Location
{
    private List<DepartmentLocation> _departmentLocations = [];
    private Location(LocationName name, LocationAddress address, LocationTimezone timezone, IEnumerable<DepartmentLocation> departmentLocations)
    {
        Id = Guid.NewGuid();
        Name = name;
        Address = address;
        Timezone = timezone;
        _departmentLocations = departmentLocations.ToList();
    }
    
    public Guid Id { get; private set; }
    public LocationName Name { get; private set; }
    public LocationAddress Address { get; private set; }
    public LocationTimezone Timezone { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }
    public IReadOnlyCollection<DepartmentLocation> DepartmentLocations => _departmentLocations;

    
    public static Result<Location> CreateLocation(
        LocationName name, 
        LocationAddress address, 
        LocationTimezone timezone, 
        IEnumerable<DepartmentLocation> departmentLocations)
    {
        return new Location(name, address, timezone, departmentLocations);
    }
}