using Prototype.Interfaces;
using Prototype.Model.Components;

namespace Prototype.Model;

/// <summary>
/// Вид роботов для помощи в домашнем хозяйстве
/// </summary>
public class HouseKeeper(string resetKeyword, ServingArea servingArea, MovingPlatform movingPlatform, string name) :
    PersonalNeedsAndroid(servingArea, movingPlatform, name)
{
    public string ResetKeyword { get; set; } = resetKeyword;

    public override string ToString()
    {
        return string.Join(Environment.NewLine, base.ToString(), $"Reset keyword: '{ResetKeyword}'");
    }

    protected HouseKeeper(HouseKeeper origin) :
        this(origin.ResetKeyword, origin.Area, origin.Platform, origin.Name) { } 

    public new HouseKeeper MyClone()
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
