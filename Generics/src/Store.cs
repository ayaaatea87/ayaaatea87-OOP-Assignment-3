using System;

using System.Collections.Generic;

public class Store<T>
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
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
