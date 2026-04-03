using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TableQueryBenchmark : MockedDynamoDbTableBenchmark
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
