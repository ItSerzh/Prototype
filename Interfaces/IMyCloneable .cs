namespace Prototype.Interfaces;

internal interface IMyCloneable<T>
{
    T DeepClone();
}
