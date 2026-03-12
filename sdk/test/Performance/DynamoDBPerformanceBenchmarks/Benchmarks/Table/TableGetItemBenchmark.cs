using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TableGetItemBenchmark : MockedDynamoDbTableBenchmark
{
    [Benchmark]
    public Task GetItemAsync() => State.TableGetItemAsync();
}
