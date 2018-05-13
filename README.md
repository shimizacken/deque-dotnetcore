# deque-dotnetcore
.NET Core implementation of a `Thread-Safe` [Double-ended queue (deque)](https://en.wikipedia.org/wiki/Double-ended_queue)

## API
| Method        | Description   |
| ------------- |---------------|
| Prepend       | insert element at front |
| Push          | insert element at back |
| PopFirst      | remove first element      |
| PopLast       | remove last element      |
| PeekFirst     | get the first element      |
| PeekLast      | get the last element      |

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
