using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableDeleteItemBenchmark : LiveDynamoDbTableBenchmark
{
    [IterationSetup]
    public void IterationSetup() => State.SeedAsync().GetAwaiter().GetResult();

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
    public Task DeleteDynamoDbEntryWithDeleteOperationConfigAsync() => State.TableDeleteDynamoDbEntryWithOperationConfigAsync();
}
