using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class DynamoDbContextScanBenchmark : MockedDynamoDbContextBenchmark
{
    [Benchmark]
    public Task ScanAsync() => State.ContextScanAsync();
}
