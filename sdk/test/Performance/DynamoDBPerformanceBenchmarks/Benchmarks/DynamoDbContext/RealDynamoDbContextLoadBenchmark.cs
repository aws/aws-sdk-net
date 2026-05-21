using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.DynamoDbContext;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class RealDynamoDbContextLoadBenchmark : LiveDynamoDbContextBenchmark
{
    [Benchmark]
    public Task LoadAsync() => State.ContextLoadAsync();

    [Benchmark]
    public Task LoadAsyncWithLoadConfig() => State.ContextLoadWithLoadConfigAsync();

    [Benchmark]
    public Task LoadAsyncKeyObject() => State.ContextLoadKeyObjectAsync();

    [Benchmark]
    public Task LoadAsyncKeyObjectWithLoadConfig() => State.ContextLoadKeyObjectWithLoadConfigAsync();
}
