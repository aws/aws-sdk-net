using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class DynamoDbContextSaveBenchmark : MockedDynamoDbContextBenchmark
{
    [Benchmark]
    public Task SaveAsync() => State.ContextSaveAsync();

    [Benchmark]
    public Task SaveAsyncWithSaveConfig() => State.ContextSaveWithSaveConfigAsync();

    [Benchmark]
    public Task SaveAsyncWithType() => State.ContextSaveWithTypeAsync();

    [Benchmark]
    public Task SaveAsyncWithTypeSaveConfig() => State.ContextSaveWithTypeSaveConfigAsync();
}
