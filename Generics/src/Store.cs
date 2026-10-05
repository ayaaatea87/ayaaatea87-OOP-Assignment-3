public class Store<T> where T : IHasId
{
    private readonly Dictionary<int, T> _items = new Dictionary<int, T>();

    public void Add(T item)
    {
        if (_items.ContainsKey(item.Id))
            throw new InvalidOperationException(
                $"An item with Id {item.Id} already exists.");

        _items.Add(item.Id, item);
    }

    public T? GetById(int id)
    {
        _items.TryGetValue(id, out T? item);
        return item;
    }

    public IReadOnlyDictionary<int, T> GetAll()
    {
        return _items;
    }

    public void Remove(int id)
    {
        _items.Remove(id);
    }
}