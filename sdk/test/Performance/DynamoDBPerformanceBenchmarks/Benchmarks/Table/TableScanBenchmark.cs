using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TableScanBenchmark : MockedDynamoDbTableBenchmark
{
    [Benchmark]
    public Task ScanAsync() => State.TableScanAsync();

    [Benchmark]
    public Task ScanWithExpressionAsync() => State.TableScanWithExpressionAsync();

    [Benchmark]
    public Task ScanWithOperationConfigAsync() => State.TableScanWithOperationConfigAsync();

    [Benchmark]
    public Task ScanWithOperationRequestAsync() => State.TableScanWithOperationRequestAsync();
}
