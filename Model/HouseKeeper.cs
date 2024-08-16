using Prototype.Interfaces;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Prototype.Tests")]

namespace Prototype.Model;

/// <summary>
/// Вид роботов для помощи в домашнем хозяйстве
/// </summary>
internal class HouseKeeper : PersonalNeedsAndroid, IMyCloneable<HouseKeeper>, ICloneable
{
    public string ResetKeyword { get; set; }


    public override string ToString()
    {
        return string.Join(Environment.NewLine, base.ToString(), $"Reset keyword: '{ResetKeyword}'");
    }

    public HouseKeeper() { }

    public HouseKeeper(HouseKeeper origin) :
        base(origin)
    {
        ResetKeyword = origin.ResetKeyword;
    }

    public HouseKeeper DeepClone()
    {
        var hk = new HouseKeeper();
        hk.ResetKeyword = ResetKeyword;
        base.ServingArea = ServingArea;
        return hk;
    }

    public object Clone()
    {
        return DeepClone();
    }
}
