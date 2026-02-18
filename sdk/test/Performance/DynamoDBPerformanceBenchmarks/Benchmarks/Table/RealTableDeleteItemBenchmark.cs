using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public sealed class RealTableDeleteItemBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task DeleteItemAsync() => State.TableDeleteItemAsync();
}
