# deque-dotnetcore
.NET Core implementation example of a `Thread-Safe` [Double-ended queue (deque)](https://en.wikipedia.org/wiki/Double-ended_queue). It's only example and not fully implemented. Inspired by [Implementing a Double-Ended Queue (or Deque) in C#](https://www.c-sharpcorner.com/UploadFile/b942f9/implementing-a-double-ended-queue-or-deque-in-C-Sharp/) and [A Deque Class in C#](https://www.codeproject.com/Articles/11754/A-Deque-Class-in-C)

## API
| Method        | Description   |
| ------------- |---------------|
| Prepend       | insert element at front |
| Push          | insert element at back  |
| PopFirst      | remove first element    |
| PopLast       | remove last element     |
| PeekFirst     | get first element without remove |
| PeekLast      | get last element without remove  |

### Prerequisites
- .NET Core SDK 2.0.0 or higher
- .NET Core Runtime 2.0.7 or higher

## Usage
Clone repository
```bash
git clone https://github.com/shimizacken/deque-dotnetcore.git
```
Restore project dependencies
```bash
dotnet restore
```
## Run Tests
For running the tests, execute the folloiwng command in the root folder of the application
```bash
dotnet xunit
```
## Remarks
The implementation includes `Deque` and `DequeSafe` classes. `DequeSafe` is a wrapper of `Deque` class that overrides its methods with a `lock` expression:

`Push` method in `Deque` class
```csharp
public virtual void Push(T item)
{      
    if (_backDeleted > 0 && _back.Count == _back.Capacity)
    {
        _back.RemoveRange(0, _backDeleted);
        _backDeleted = 0;
    }

    _back.Add(item);
}
```

`Push` method in `DequeSafe` class
```csharp
public override void Push(T item)
{
    lock(root)
    {
        base.Push(item);
    }
}
```
