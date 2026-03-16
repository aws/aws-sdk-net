using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TablePutItemBenchmark : MockedDynamoDbTableBenchmark
{
    [Benchmark]
    public Task PutItemAsync() => State.TablePutItemAsync();

    [Benchmark]
    public Task PutItemWithOperationConfigAsync() => State.TablePutItemWithOperationConfigAsync();

    [Benchmark]
    public Task PutItemWithOperationRequestAsync() => State.TablePutItemWithOperationRequestAsync();
}
