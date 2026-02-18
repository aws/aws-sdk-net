using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public sealed class RealDynamoDbContextScanBenchmark : LiveDynamoDbContextBenchmark
{
    [Benchmark]
    public Task ScanAsync() => State.ContextScanAsync();
}
