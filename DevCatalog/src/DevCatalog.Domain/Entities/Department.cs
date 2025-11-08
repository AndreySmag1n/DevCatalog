using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;
using DevCatalog.Domain.ValueObjects;

namespace DevCatalog.Domain.Entities;

public class Department
{
    private List<Department> _children = [];
    private List<Location> _locations = [];
    private List<Position> _positions = [];
    
    private Department(
        DepartmentName name, 
        DepartmentPath path, 
        DepartmentIdentifier identifier, 
        Department? parent, 
        short depth,
        IEnumerable<Department> children,
        IEnumerable<Location> locations,
        IEnumerable<Position> positions)
    {
        Id = Guid.NewGuid();
        Name = name;
        Parent = parent;
        Path = path;
        Identifier = identifier;
        Depth = depth;
        _children = children.ToList();
        _locations = locations.ToList();
        _positions = positions.ToList();
    }
    
    public Guid Id { get; private set; }
    
    //public Guid? ParentId { get; private set; }
    public Department? Parent { get; private set; }
    public DepartmentName Name { get; private set; }
    public DepartmentIdentifier Identifier { get; private set; }
    public DepartmentPath Path { get; private set; }
    public short Depth { get; private set; }

    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }
    public IReadOnlyList<Department> Children => _children;
    public IReadOnlyList<Location> Locations => _locations;
    public IReadOnlyList<Position> Positions => _positions;
    
    public static Result<Department> CreateDepartment(
        DepartmentName name, 
        DepartmentPath path, 
        DepartmentIdentifier identifier, 
        Department? parent, 
        short depth,
        IEnumerable<Department> children,
        IEnumerable<Location> locations,
        IEnumerable<Position> positions)
    {
        if (depth < 1)    
        {
            return Result.Failure<Department>("Глубина подразделения не может быть меньше 1!");
        }
        
        return new Department(name, path, identifier, parent, depth, children, locations, positions);
    }
}