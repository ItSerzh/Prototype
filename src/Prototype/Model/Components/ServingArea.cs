namespace Prototype.Model.Components;

/// <summary>
/// Область применения, на которую рассчината прошивка
/// </summary>
public class ServingArea(string name)
{
    public string Name { get; set; } = name;
}
