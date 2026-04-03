using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableQueryBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task QueryAsync() => State.TableQueryAsync();

    [Benchmark]
    public Task QueryWithExpressionAsync() => State.TableQueryWithExpressionAsync();

    [Benchmark]
    public Task QueryWithFilterAsync() => State.TableQueryWithFilterAsync();

    [Benchmark]
    public Task QueryWithOperationConfigAsync() => State.TableQueryWithOperationConfigAsync();

    [Benchmark]
    public Task QueryWithOperationRequestAsync() => State.TableQueryWithOperationRequestAsync();
}
