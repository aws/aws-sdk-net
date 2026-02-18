using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public sealed class RealDynamoDbContextDeleteBenchmark : LiveDynamoDbContextBenchmark
{
    [Benchmark]
    public Task DeleteAsync() => State.ContextDeleteAsync();

    [Benchmark]
    public Task DeleteAsyncWithOperationConfig() => State.ContextDeleteWithOperationConfigAsync();

    [Benchmark]
    public Task DeleteAsyncWithDeleteConfig() => State.ContextDeleteWithDeleteConfigAsync();

    [Benchmark]
    public Task DeleteAsyncHashKey() => State.ContextDeleteHashKeyAsync();

    [Benchmark]
    public Task DeleteAsyncHashKeyWithOperationConfig() => State.ContextDeleteHashKeyWithOperationConfigAsync();

    [Benchmark]
    public Task DeleteAsyncHashKeyWithDeleteConfig() => State.ContextDeleteHashKeyWithDeleteConfigAsync();

    [Benchmark]
    public Task DeleteAsyncHashKeyRangeKey() => State.ContextDeleteHashKeyRangeKeyAsync();

    [Benchmark]
    public Task DeleteAsyncHashKeyRangeKeyWithOperationConfig() => State.ContextDeleteHashKeyRangeKeyWithOperationConfigAsync();

    [Benchmark]
    public Task DeleteAsyncHashKeyRangeKeyWithDeleteConfig() => State.ContextDeleteHashKeyRangeKeyWithDeleteConfigAsync();
}
