using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableScanBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task ScanAsync() => State.TableScanAsync();
}
