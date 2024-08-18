using Prototype.Interfaces;
using Prototype.Model.Components;

namespace Prototype.Model;

/// <summary>
/// Робот для частного использования
/// </summary>
public class PersonalNeedsAndroid(ServingArea servingArea, MovingPlatform movingPlatform, string name) :
    Android(movingPlatform, name)
{
    public ServingArea ServingArea { get; set; } = servingArea;

    protected PersonalNeedsAndroid(PersonalNeedsAndroid origin) : 
        this(origin.ServingArea, origin.Platform, origin.Name) { }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, base.ToString(), $"Can serve in: '{ServingArea.Name}'");
    }

    public PersonalNeedsAndroid DeepClone()
    {
        return new (this);
    }

    public object Clone()
    {
        return DeepClone();
    }
}
