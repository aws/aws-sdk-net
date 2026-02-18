using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public sealed class RealTableScanBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task ScanAsync() => State.TableScanAsync();
}
