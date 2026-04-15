using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class RealDynamoDbContextScanBenchmark : LiveDynamoDbContextBenchmark
{
    [Benchmark]
    public Task ScanAsync() => State.ContextScanAsync();

    [Benchmark]
    public Task ScanWithScanConditionOperationConfigAsync() => State.ContextScanWithScanConditionOperationConfigAsync();

    [Benchmark]
    public Task ScanWithScanConditionScanConfigAsync() => State.ContextScanWithScanConditionScanConfigAsync();

    [Benchmark]
    public Task ScanWithContextExpression() => State.ContextScanWithContextExpression();

    [Benchmark]
    public Task ScanWithContextExpressionScanCondition() => State.ContextScanWithContextExpressionScanCondition();
}
