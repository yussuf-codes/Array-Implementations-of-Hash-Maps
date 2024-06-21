using System;
using HashMap.Interfaces;

namespace HashMap.Implementations.SeparateChaining;

public class HashMap<Key, Value> : IHashMap<Key, Value>
{
    private class Node
    {
        public required Node Next { get; set; }
        public required Value Value { get; set; }
    }

    private int[] associative_array;

    private int associative_array_length;

    public void Add(Key key, Value value)
    {
        throw new NotImplementedException();
    }

    public Value Get(Key key)
    {
        throw new NotImplementedException();
    }

    public Key[] Keys()
    {
        throw new NotImplementedException();
    }

    public void Remove(Key key)
    {
        throw new NotImplementedException();
    }

    public void Update(Key key, Value value)
    {
        throw new NotImplementedException();
    }
}
