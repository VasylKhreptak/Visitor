public interface IVisitable<T>
{
    public void Accept(T visitor);
}
