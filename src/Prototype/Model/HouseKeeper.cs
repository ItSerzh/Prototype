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
        this(origin.ResetKeyword, origin.ServingArea, origin.Platform, origin.Name) { } 

    public HouseKeeper DeepClone()
    {
        return new (this);
    }

    public object Clone()
    {
        return DeepClone();
    }
}
