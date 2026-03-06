using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class DynamoDbContextQueryBenchmark : MockedDynamoDbContextBenchmark
{
    [Benchmark]
    public Task QueryAsync() => State.ContextQueryAsync();
}
