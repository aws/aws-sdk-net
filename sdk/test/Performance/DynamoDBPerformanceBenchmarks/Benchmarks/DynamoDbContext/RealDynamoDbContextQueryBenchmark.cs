using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public sealed class RealDynamoDbContextQueryBenchmark : LiveDynamoDbContextBenchmark
{
    [Benchmark]
    public Task QueryAsync() => State.ContextQueryAsync();
}
