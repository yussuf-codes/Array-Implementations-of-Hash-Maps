namespace HashMap.Interfaces;

public interface IHashMap<Key, Value>
{
    void Add(Key key, Value value);
    Value Get(Key key);
    Key[] Keys();
    void Remove(Key key);
    void Update(Key key, Value value);
}
