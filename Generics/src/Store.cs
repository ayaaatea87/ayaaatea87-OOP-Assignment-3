public class Store<T> where T : IHasId
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T? GetById(int id)
    {
        foreach (var item in _items)
        {
            if (item.Id == id)
                return item;
        }

        return default;
    }

    public List<T> GetAll()
    {
        return _items;
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }
}