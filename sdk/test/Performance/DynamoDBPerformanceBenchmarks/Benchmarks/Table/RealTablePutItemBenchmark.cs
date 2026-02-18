using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public sealed class RealTablePutItemBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task PutItemAsync() => State.TablePutItemAsync();
}
