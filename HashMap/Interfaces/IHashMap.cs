namespace HashMap.Interfaces;

public interface IHashMap<Key, Value>
{
    // Time Complexity: O(1)
    void Add(Key key, Value value);

    // Time Complexity: O(1)
    Value Get(Key key);

    // Time Complexity: O(n)
    Key[] Keys();

    // Time Complexity: O(1)
    void Remove(Key key);

    // Time Complexity: O(1)
    void Update(Key key, Value value);
}
