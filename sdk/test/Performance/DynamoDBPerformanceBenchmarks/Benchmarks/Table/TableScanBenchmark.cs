using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TableScanBenchmark : MockedDynamoDbTableBenchmark
{
    [Benchmark]
    public Task ScanAsync() => State.TableScanAsync();
}
