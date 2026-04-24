using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class RealDynamoDbContextQueryBenchmark : LiveDynamoDbContextBenchmark
{
    [Benchmark]
    public Task QueryAsync() => State.ContextQueryAsync();

    [Benchmark]
    public Task QueryWithQueryConfigAsync() => State.ContextQueryWithQueryConfigAsync();

    [Benchmark]
    public Task QueryWithOperationConfigAsync() => State.ContextQueryWithOperationConfigAsync();

    [Benchmark]
    public Task QueryWithQueryConditionalQueryConfigAsync() => State.ContextQueryWithQueryConditionalQueryConfigAsync();

    [Benchmark]
    public Task QueryWithQueryOperatorAsync() => State.ContextQueryWithQueryOperatorAsync();

    [Benchmark]
    public Task QueryWithQueryOperatorQueryConfigAsync() => State.ContextQueryWithQueryOperatorQueryConfigAsync();

    [Benchmark]
    public Task QueryWithQueryOperatorOperationConfigAsync() => State.ContextQueryWithQueryOperatorOperationConfigAsync();
}
