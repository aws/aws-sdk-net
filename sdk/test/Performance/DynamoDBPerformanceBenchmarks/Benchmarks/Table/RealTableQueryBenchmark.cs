using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableQueryBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task QueryAsync() => State.TableQueryAsync();
}
