using Prototype.Interfaces;
using Prototype.Model.Components;

namespace Prototype.Model;

/// <summary>
/// Робот для частного использования
/// </summary>
public class PersonalNeedsAndroid(ServingArea servingArea, MovingPlatform movingPlatform, string name) :
    Android(movingPlatform, name)
{
    public ServingArea Area { get; set; } = servingArea;

    protected PersonalNeedsAndroid(PersonalNeedsAndroid origin) : 
        this(origin.Area, origin.Platform, origin.Name) { }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, base.ToString(), $"Can serve in: '{Area.Name}'");
    }

    public new PersonalNeedsAndroid MyClone()
    {
        return new (this);
    }

    public new object Clone()
    {
        var clone = MyClone();
        clone.Area = new ServingArea(Area.Name);
        clone.Platform = new MovingPlatform(Platform.Name);
        return clone;
    }
}
