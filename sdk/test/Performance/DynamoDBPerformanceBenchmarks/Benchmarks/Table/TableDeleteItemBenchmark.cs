using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TableDeleteItemBenchmark : MockedDynamoDbTableBenchmark
{
    [Benchmark]
    public Task DeleteItemAsync() => State.TableDeleteItemAsync();
}
