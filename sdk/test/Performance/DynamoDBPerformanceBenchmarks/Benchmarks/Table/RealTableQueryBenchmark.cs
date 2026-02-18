using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public sealed class RealTableQueryBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task QueryAsync() => State.TableQueryAsync();
}
