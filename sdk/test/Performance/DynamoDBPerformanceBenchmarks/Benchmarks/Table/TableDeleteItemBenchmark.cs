using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace AWSSDK.Benchmarks.MockedDynamoDB.Table;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class TableDeleteItemBenchmark : MockedDynamoDbTableBenchmark
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
    public Task DeteleDynamoDbEntry() => State.TableDeteleDynamoDbEntry();

    [Benchmark]
    public Task DeteleDynamoDbEntryWithDeleteConfigAsync() => State.TableDeteleDynamoDbEntryWithOperationConfigAsync();

}
