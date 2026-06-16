using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class DynamoDbContextQueryBenchmark : MockedDynamoDbContextBenchmark
{
    [Benchmark]
    public Task QueryAsync() => State.ContextQueryAsync();

    [Benchmark]
    public Task QueryWithQueryConfigAsync() => State.ContextQueryWithQueryConfigAsync();

    [Benchmark]
    public Task QueryWithQueryConditionalQueryConfigAsync() => State.ContextQueryWithQueryConditionalQueryConfigAsync();

    [Benchmark]
    public Task QueryWithQueryOperatorAsync() => State.ContextQueryWithQueryOperatorAsync();
}
