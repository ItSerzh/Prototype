using Prototype.Interfaces;
using Prototype.Model.Components;

namespace Prototype.Model;

/// <summary>
/// Робот для частного использования
/// </summary>
internal class PersonalNeedsAndroid : Android, IMyCloneable<PersonalNeedsAndroid>, ICloneable
{
    public ServingArea ServingArea { get; set; } = new ServingArea();
    public PersonalNeedsAndroid() : base() { }

    public PersonalNeedsAndroid(PersonalNeedsAndroid origin) : base(origin)

    {
        ServingArea = origin.ServingArea;
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, base.ToString(), $"Can serve in:  '{ServingArea.Name}'");
    }

    public PersonalNeedsAndroid DeepClone()
    {
        var pna = new PersonalNeedsAndroid();
        pna.ServingArea = ServingArea;
        return pna;
    }

    public object Clone()
    {
        return DeepClone();
    }
}
