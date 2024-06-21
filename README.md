# Hash Maps

### Hash maps are data structures that allow efficient storage and retrieval of key-value pairs. They are commonly used in computer science and programming to implement associative arrays or dictionaries.

### A hash map consists of an array of slots or buckets, where each slot can store a key-value pair. When a value is added to the hash maps, a hash function is used to generate a unique index or hash code for the corresponding key. This hash code is then used to determine the slot where the value should be stored.

### One of the key advantages of hash maps is their ability to provide constant-time average-case complexity for basic operations such as insertion, deletion, and retrieval. This is achieved by ensuring that the hash function distributes the keys uniformly across the available slots, minimizing collisions where multiple keys map to the same slot.

### In the case of a collision, where two or more keys map to the same slot, different collision resolution techniques can be used to handle the situation. These techniques include separate chaining, where each slot contains a linked list of key-value pairs, and open addressing, where the hash map is probed sequentially to find an empty slot.

### Overall, hash maps are a powerful and efficient data structure for storing and retrieving data, particularly when the number of elements is large and the access patterns are unpredictable. They are widely used in various applications, such as database indexing & caching.

## 1. Hash collision resolved by separate chaining
![Hash collision resolved by separate chaining](./Illustrations/Hash%20collision%20resolved%20by%20separate%20chaining.png)

## 2. Hash collision resolved by open addressing
![Hash collision resolved by open addressing](./Illustrations/Hash%20collision%20resolved%20by%20open%20addressing.png)
