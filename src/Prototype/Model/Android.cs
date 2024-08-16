using Prototype.Interfaces;
using Prototype.Model.Components;

namespace Prototype.Model;

/// <summary>
/// Человекоподобный робот
/// </summary>
internal class Android : IMyCloneable<Android>, ICloneable
{
    public MovingPlatform Platform { get; set; } = new MovingPlatform();
    public string Name { get; set; } = string.Empty;

    public Android() { }

    public Android(Android origin) : this()
    {
        Platform = origin.Platform;
        Name = origin.Name;
    }

    
    public override string ToString()
    {
        return $"Androig '{Name}' moves with '{Platform.Name}'";
    }

    public Android DeepClone()
    {
        var clone = new Android();
        clone.Platform = Platform;
        clone.Name = Name;
        return clone ;
    }

    public object Clone()
    {
        return DeepClone();
    }
}
