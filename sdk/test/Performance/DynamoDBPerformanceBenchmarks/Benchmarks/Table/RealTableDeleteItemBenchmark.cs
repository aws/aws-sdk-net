using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableDeleteItemBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task DeleteItemAsync() => State.TableDeleteItemAsync();
}
