using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TableGetItemBenchmark : MockedDynamoDbTableBenchmark
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
