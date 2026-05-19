using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;


[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class DynamoDbContextDeleteBenchmark : MockedDynamoDbContextDeleteBenchmark
{
    [Benchmark]
    public Task DeleteAsync() => State.ContextDeleteAsync();

    [Benchmark]
    public Task DeleteAsyncWithDeleteConfig() => State.ContextDeleteWithDeleteConfigAsync();

    [Benchmark]
    public Task DeleteAsyncHashKeyRangeKey() => State.ContextDeleteHashKeyRangeKeyAsync();

    [Benchmark]
    public Task DeleteAsyncHashKeyRangeKeyWithDeleteConfig() => State.ContextDeleteHashKeyRangeKeyWithDeleteConfigAsync();
}
