using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableDeleteItemBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task DeleteItemAsync() => State.TableDeleteItemAsync();

    [Benchmark]
    public Task DeleteDocumentAsync() => State.TableDeleteDocumentAsync();

    [Benchmark]
    public Task DeleteDocumentWithOperationConfigAsync() => State.TableDeleteDocumentWithOperationConfigAsync();

    [Benchmark]
    public Task DeleteHashKeyRangeKeyWithOperationConfigAsync() => State.TableDeleteHashKeyRangeKeyWithOperationConfigAsync();

    [Benchmark]
    public Task DeleteWithOperationRequest() => State.TableDeleteWithOperationRequest();

    [Benchmark]
    public Task DeleteDynamoDbEntry() => State.TableDeleteDynamoDbEntry();

    [Benchmark]
    public Task DeleteDynamoDbEntryWithDeleteConfigAsync() => State.TableDeleteDynamoDbEntryWithOperationConfigAsync();
}
