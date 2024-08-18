using Prototype.Interfaces;
using Prototype.Model.Components;
using System.Runtime.CompilerServices;

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

    public Android MyClone()
    {
        return  new (this);
    }

    /// <summary>
    /// Реализуем полный клон объекта
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
        var clone = MyClone();
        clone.Platform = new MovingPlatform(Platform.Name);
        return clone;
    }
}
