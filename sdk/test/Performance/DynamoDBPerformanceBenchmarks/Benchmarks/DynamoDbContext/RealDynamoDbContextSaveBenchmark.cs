using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public sealed class RealDynamoDbContextSaveBenchmark : LiveDynamoDbContextBenchmark
{
    [Benchmark]
    public Task SaveAsync() => State.ContextSaveAsync();

    [Benchmark]
    public Task SaveAsyncWithOperationConfig() => State.ContextSaveWithOperationConfigAsync();

    [Benchmark]
    public Task SaveAsyncWithSaveConfig() => State.ContextSaveWithSaveConfigAsync();

    [Benchmark]
    public Task SaveAsyncWithType() => State.ContextSaveWithTypeAsync();

    [Benchmark]
    public Task SaveAsyncWithTypeOperationConfig() => State.ContextSaveWithTypeOperationConfigAsync();

    [Benchmark]
    public Task SaveAsyncWithTypeSaveConfig() => State.ContextSaveWithTypeSaveConfigAsync();
}
