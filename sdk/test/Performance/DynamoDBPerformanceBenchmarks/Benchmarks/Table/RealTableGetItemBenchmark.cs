using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableGetItemBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task GetItemAsync() => State.TableGetItemAsync();
}
