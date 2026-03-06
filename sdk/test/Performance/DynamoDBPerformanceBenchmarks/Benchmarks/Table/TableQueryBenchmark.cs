using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TableQueryBenchmark : MockedDynamoDbTableBenchmark
{
    [Benchmark]
    public Task QueryAsync() => State.TableQueryAsync();
}
