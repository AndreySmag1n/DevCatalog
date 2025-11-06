using CSharpFunctionalExtensions;
using DevCatalog.Domain.ValueObjects;

namespace DevCatalog.Domain.Entities;

public class Location
{
    private Location(LocationName name, LocationAddress address, LocationTimezone timezone)
    {
        Id = Guid.NewGuid();
        Name = name;
        Address = address;
        Timezone = timezone;
    }
    
    public Guid Id { get; private set; }
    public LocationName Name { get; private set; }
    public LocationAddress Address { get; private set; }
    public LocationTimezone Timezone { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }

    
    public static Result<Location> CreateLocation(LocationName name, LocationAddress address, LocationTimezone timezone)
    {
        return new Location(name, address, timezone);
    }
}