using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableScanBenchmark : LiveDynamoDbTableBenchmark
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
