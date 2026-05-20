using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTablePutItemBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task PutItemAsync() => State.TablePutItemAsync();

    [Benchmark]
    public Task PutItemWithOperationConfigAsync() => State.TablePutItemWithOperationConfigAsync();

    [Benchmark]
    public Task PutItemWithOperationRequestAsync() => State.TablePutItemWithOperationRequestAsync();
}
