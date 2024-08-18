namespace Prototype.Interfaces;

/// <summary>
/// Интефйес для поверхностного клонирования
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IMyCloneable<T>
{
    T MyClone();
}
