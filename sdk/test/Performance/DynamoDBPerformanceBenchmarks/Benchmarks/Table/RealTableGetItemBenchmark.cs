using BenchmarkDotNet.Attributes;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

public class RealTableGetItemBenchmark : LiveDynamoDbTableBenchmark
{
    [Benchmark]
    public Task GetItemAsync() => State.TableGetItemAsync();

    [Benchmark]
    public Task GetHashKeyRangeKeyWithOperationConfigAsync() => State.TableGetHashKeyRangeKeyWithOperationConfigAsync();

    [Benchmark]
    public Task GetWithOperationRequest() => State.TableGetWithOperationRequest();

    [Benchmark]
    public Task GetDynamoDbEntry() => State.TableGetDynamoDbEntry();

    [Benchmark]
    public Task GetDynamoDbEntryWithOperationConfigAsync() => State.TableGetDynamoDbEntryWithOperationConfigAsync();
}
