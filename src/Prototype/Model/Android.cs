using Prototype.Interfaces;
using Prototype.Model.Components;

namespace Prototype.Model;

/// <summary>
/// Человекоподобный робот
/// </summary>
public class Android(MovingPlatform movingPlatform, string name) : IMyCloneable<Android>, ICloneable
{
    public MovingPlatform Platform { get; set; } = movingPlatform;
    public string Name { get; set; } = name;

    public Android(Android origin) : this(origin.Platform, origin.Name) { }
    
    public override string ToString()
    {
        return $"Androig '{Name}' moves with '{Platform.Name}'";
    }

    public Android DeepClone()
    {
        return  new Android(Platform, Name);
    }

    public object Clone()
    {
        return DeepClone();
    }
}
