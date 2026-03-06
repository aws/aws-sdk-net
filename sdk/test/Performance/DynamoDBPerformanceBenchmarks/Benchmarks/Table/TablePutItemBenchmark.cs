using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TablePutItemBenchmark : MockedDynamoDbTableBenchmark
{
    [Benchmark]
    public Task PutItemAsync() => State.TablePutItemAsync();
}
